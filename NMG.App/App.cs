﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using NMG.Core;
using NMG.Core.Domain;
using NMG.Core.Reader;
using NMG.Core.TextFormatter;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace NHibernateMappingGenerator
{
    public partial class App : Form
    {
        private IMetadataReader metadataReader;
        private readonly BackgroundWorker worker;
        private IList<Column> gridData;
        private ApplicationSettings applicationSettings;
        private IList<Table> _tables;
        private Connection _currentConnection;
        MySetting mySetting
        {
            get
            {
                if (applicationSettings != null) return applicationSettings.mySetting;
                return null;
            }
            set
            {
                applicationSettings.mySetting = value;
            }
        }
        public App()
        {
            InitializeComponent();
            ownersComboBox.SelectedIndexChanged += OwnersSelectedIndexChanged;
            tablesListBox.SelectedIndexChanged += TablesListSelectedIndexChanged;
            connectionNameComboBox.SelectedIndexChanged += ConnectionNameSelectedIndexChanged;
            dbTableDetailsGridView.DataError += DataError;
            connectionButton.Click += ConnectionButtonClick;
            dbTableDetailsGridView.CurrentCellDirtyStateChanged += OnTableDetailsCellDirty;
            BindData();

            sequencesComboBox.Enabled = false;
            TableFilterTextBox.Enabled = false;
            Closing += App_Closing;
            worker = new BackgroundWorker { WorkerSupportsCancellation = true };
            mainTabControl.TabPages.Remove(advanceSettingsTabPage);
        }

        private void OnTableDetailsCellDirty(object sender, EventArgs e)
        {
            if (_currentTable != null)
            {
                // Update map and domain code to reflect changes in grid.
                GenerateAndDisplayCode(_currentTable);

                ToggleColumnsBasedOnAppSettings(applicationSettings);
            }
        }

        private void ConnectionButtonClick(object sender, EventArgs e)
        {
            // Belt and braces
            if (applicationSettings == null)
            {
                LoadApplicationSettings();
            }

            var connectionDialog = new ConnectionDialog();

            // Edit current connection
            if (_currentConnection != null)
            {
                connectionDialog.Connection = _currentConnection;
            }

            var result = connectionDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    // Add or Update Connection
                    _currentConnection = connectionDialog.Connection;
                    var connectionToUpdate = applicationSettings.Connections.FirstOrDefault(connection => connection.Id == _currentConnection.Id);

                    if (connectionToUpdate == null)
                    {
                        // Add new connection
                        applicationSettings.Connections.Add(_currentConnection);
                    }

                    break;
                case DialogResult.Abort:
                    // Delete Connection
                    applicationSettings.Connections.Remove(_currentConnection);
                    _currentConnection = null;
                    break;
            }

            // Refresh data connections drop down
            connectionNameComboBox.DataSource = null;
            connectionNameComboBox.DataSource = applicationSettings.Connections;
            connectionNameComboBox.DisplayMember = "Name";
            connectionNameComboBox.SelectedItem = _currentConnection;

            fastColoredTextBox5.Text = CodeMaker.MakeDbConfig(applicationSettings.Connections, checkBox4.Checked);
        }

        private void ConnectionNameSelectedIndexChanged(object sender, EventArgs e)
        {
            if (connectionNameComboBox.SelectedItem == null) return;

            _currentConnection = (Connection)connectionNameComboBox.SelectedItem;

            pOracleOnlyOptions.Hide();

            if (_currentConnection.Type == ServerType.Oracle)
                pOracleOnlyOptions.Show();
        }


        private Language LanguageSelected
        {
            get { return vbRadioButton.Checked ? Language.VB : Language.CSharp; }
        }

        public bool IsFluent
        {
            get { return fluentMappingOption.Checked; }
        }

        public bool IsEntityFramework
        {
            get { return entityFrameworkRadionBtn.Checked; }
        }

        public bool IsCastle
        {
            get { return castleMappingOption.Checked; }
        }

        public bool IsByCode
        {
            get { return byCodeMappingOption.Checked; }
        }

        protected override void OnLoad(EventArgs e)
        {
            fastColoredTextBox5.Language = FastColoredTextBoxNS.Language.HTML;
            LoadApplicationSettings();
        }

        void LoadMySetting()
        {
            if (mySetting == null) mySetting = new MySetting();
            DomainFolderTextBox.Text = mySetting.DominFolderPath;
            IReposityFolderTextBox.Text = mySetting.IReposityFolderPath;
            ReposityFolderTextBox.Text = mySetting.ReposityFolderPath;
            DomainNmespaceTextBox.Text = mySetting.DominNamespace;
            IReposityNamespaceTextBox.Text = mySetting.IReposityNamespace;
            ReposityNamespaceTextBox.Text = mySetting.ReposityNamespace;

            textBox1.Text = mySetting.DomainDir;
            textBox2.Text = mySetting.IReposityDir;
            textBox3.Text = mySetting.ReposityDir;
            checkBox5.Checked = mySetting.IsUseDir;
        }
        private void LoadApplicationSettings()
        {
            applicationSettings = ApplicationSettings.Load();
            if (applicationSettings != null)
            {
                // Display all previous connections
                connectionNameComboBox.DataSource = applicationSettings.Connections;
                connectionNameComboBox.DisplayMember = "Name";
                fastColoredTextBox5.Text = CodeMaker.MakeDbConfig(applicationSettings.Connections, checkBox4.Checked);
                // Set the last used connection
                var lastUsedConnection =
                    applicationSettings.Connections.FirstOrDefault(connection => connection.Id == applicationSettings.LastUsedConnection);
                _currentConnection = lastUsedConnection ?? applicationSettings.Connections.FirstOrDefault();
                connectionNameComboBox.SelectedItem = _currentConnection;

                DomainNmespaceTextBox.Text = applicationSettings.NameSpace;
                IReposityNamespaceTextBox.Text = applicationSettings.NameSpaceMap;
                ReposityNamespaceTextBox.Text = applicationSettings.AssemblyName;
                cSharpRadioButton.Checked = applicationSettings.Language == Language.CSharp;
                vbRadioButton.Checked = applicationSettings.Language == Language.VB;
                noValidationRadioButton.Checked = applicationSettings.ValidationStyle == ValidationStyle.None;
                nhibernateValidationRadioButton.Checked = applicationSettings.ValidationStyle == ValidationStyle.Nhibernate;
                dataAnnotationsRadioButton.Checked = applicationSettings.ValidationStyle == ValidationStyle.Microsoft;
                autoPropertyRadioBtn.Checked = applicationSettings.IsAutoProperty;
                DomainFolderTextBox.Text = applicationSettings.FolderPath;
                IReposityFolderTextBox.Text = applicationSettings.DomainFolderPath;
                textBoxInheritence.Text = applicationSettings.InheritenceAndInterfaces;
                comboBoxForeignCollection.Text = applicationSettings.ForeignEntityCollectionType;
                textBoxClassNamePrefix.Text = applicationSettings.ClassNamePrefix;
                EnableInflectionsCheckBox.Checked = applicationSettings.EnableInflections;
                wcfDataContractCheckBox.Checked = applicationSettings.GenerateWcfContracts;
                partialClassesCheckBox.Checked = applicationSettings.GeneratePartialClasses;
                useLazyLoadingCheckBox.Checked = applicationSettings.UseLazy;
                includeLengthAndScaleCheckBox.Checked = applicationSettings.IncludeLengthAndScale;
                includeForeignKeysCheckBox.Checked = applicationSettings.IncludeForeignKeys;
                nameAsForeignTableCheckBox.Checked = applicationSettings.NameFkAsForeignTable;
                includeHasManyCheckBox.Checked = applicationSettings.IncludeHasMany;

                fluentMappingOption.Checked = applicationSettings.IsFluent;
                entityFrameworkRadionBtn.Checked = applicationSettings.IsEntityFramework;
                castleMappingOption.Checked = applicationSettings.IsCastle;
                byCodeMappingOption.Checked = applicationSettings.IsByCode;

                if (applicationSettings.FieldPrefixRemovalList == null)
                    applicationSettings.FieldPrefixRemovalList = new List<string>();

                fieldPrefixListBox.Items.AddRange(applicationSettings.FieldPrefixRemovalList.ToArray());
                removeFieldPrefixButton.Enabled = false;

                prefixRadioButton.Checked = !string.IsNullOrEmpty(applicationSettings.Prefix);
                prefixTextBox.Text = applicationSettings.Prefix;
                camelCasedRadioButton.Checked = (applicationSettings.FieldNamingConvention == FieldNamingConvention.CamelCase);
                pascalCasedRadioButton.Checked = (applicationSettings.FieldNamingConvention == FieldNamingConvention.PascalCase);
                sameAsDBRadioButton.Checked = (applicationSettings.FieldNamingConvention == FieldNamingConvention.SameAsDatabase);

                sameAsDBRadioButton.Checked = (!prefixRadioButton.Checked && !pascalCasedRadioButton.Checked &&
                                               !camelCasedRadioButton.Checked);

                generateInFoldersCheckBox.Checked = applicationSettings.GenerateInFolders;

                SetCodeControlFormatting(applicationSettings);
            }
            else
            {
                // Default application settings
                autoPropertyRadioBtn.Checked = true;
                pascalCasedRadioButton.Checked = true;
                cSharpRadioButton.Checked = true;
                byCodeMappingOption.Checked = true;
                includeForeignKeysCheckBox.Checked = true;
                nameAsForeignTableCheckBox.Checked = true;
                includeHasManyCheckBox.Checked = false;
                useLazyLoadingCheckBox.Checked = true;

                comboBoxForeignCollection.Text = "IList";

                CaptureApplicationSettings();
            }

            if (!prefixRadioButton.Checked)
            {
                prefixLabel.Visible = prefixTextBox.Visible = false;
            }
            LoadMySetting();
        }

        private void ToggleColumnsBasedOnAppSettings(ApplicationSettings appSettings)
        {
            var lengthColumn = dbTableDetailsGridView.Columns["DataLength"];
            if (lengthColumn != null)
                lengthColumn.Visible = appSettings.IncludeLengthAndScale;

            var precisionColumn = dbTableDetailsGridView.Columns["DataPrecision"];
            if (precisionColumn != null)
                precisionColumn.Visible = appSettings.IncludeLengthAndScale;

            var scaleColumn = dbTableDetailsGridView.Columns["DataScale"];
            if (scaleColumn != null)
                scaleColumn.Visible = appSettings.IncludeLengthAndScale;

            var cSharpTypeColumn = dbTableDetailsGridView.Columns["cSharpType"];
            if (cSharpTypeColumn != null)
                cSharpTypeColumn.Visible = !appSettings.IsByCode;

            /*var fkTableNameColumn = dbTableDetailsGridView.Columns["ForeignKeyTableName"];
            var fkColNameColumn = dbTableDetailsGridView.Columns["ForeignKeyColumnName"];
            if (fkColNameColumn != null && fkTableNameColumn != null)
            {
                if (_currentTable.ForeignKeys.Count != 0)
                {
                    // Disable foreign key columns
                    fkTableNameColumn.ReadOnly = false;
                    fkColNameColumn.ReadOnly = false;
                }
                else
                {
                    // Enable foreign key columns
                    fkTableNameColumn.ReadOnly = true;
                    fkColNameColumn.ReadOnly = true;
                }
            }*/
        }

        private void SetCodeControlFormatting(ApplicationSettings appSettings)
        {
            // Domain Code Formatting
            if (appSettings.Language == Language.CSharp)
            {
                domainCodeFastColoredTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            }
            else if (appSettings.Language == Language.VB)
            {
                domainCodeFastColoredTextBox.Language = FastColoredTextBoxNS.Language.VB;
            }

            if (appSettings.Language == Language.CSharp)
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            }
            else if (appSettings.Language == Language.VB)
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB;
            }

            if (appSettings.Language == Language.CSharp)
            {
                fastColoredTextBox2.Language = FastColoredTextBoxNS.Language.CSharp;
            }
            else if (appSettings.Language == Language.VB)
            {
                fastColoredTextBox2.Language = FastColoredTextBoxNS.Language.VB;
            }

            if (appSettings.Language == Language.CSharp)
            {
                fastColoredTextBox3.Language = FastColoredTextBoxNS.Language.CSharp;
            }
            else if (appSettings.Language == Language.VB)
            {
                fastColoredTextBox3.Language = FastColoredTextBoxNS.Language.VB;
            }

            if (appSettings.Language == Language.CSharp)
            {
                fastColoredTextBox4.Language = FastColoredTextBoxNS.Language.CSharp;
            }
            else if (appSettings.Language == Language.VB)
            {
                fastColoredTextBox4.Language = FastColoredTextBoxNS.Language.VB;
            }


            //// Map Code Formatting
            //if (appSettings.Language == Language.CSharp & appSettings.IsByCode || appSettings.IsFluent || appSettings.IsNhFluent || appSettings.IsCastle || appSettings.IsEntityFramework)
            //{
            //    mapCodeFastColoredTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            //}
            //else if (appSettings.Language == Language.VB & appSettings.IsByCode || appSettings.IsFluent || appSettings.IsNhFluent || appSettings.IsCastle || appSettings.IsEntityFramework)
            //{
            //    mapCodeFastColoredTextBox.Language = FastColoredTextBoxNS.Language.VB;
            //}
            //else
            //{
            //    mapCodeFastColoredTextBox.Language = FastColoredTextBoxNS.Language.HTML;
            //}
        }

        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            toolStripStatusLabel.Text = string.Format("Error in column {0} of row {1} - {3}. Detail : {2}", e.ColumnIndex, e.RowIndex, e.Exception.Message, (gridData != null ? gridData[e.RowIndex].Name : ""));
        }

        private void App_Closing(object sender, CancelEventArgs e)
        {
            CaptureApplicationSettings();
            applicationSettings.Save();
        }

        private void CaptureApplicationSettings()
        {
            if (applicationSettings == null)
            {
                applicationSettings = new ApplicationSettings();
            }
            applicationSettings.NameSpace = DomainNmespaceTextBox.Text;
            applicationSettings.NameSpaceMap = IReposityNamespaceTextBox.Text;
            applicationSettings.AssemblyName = ReposityNamespaceTextBox.Text;
            applicationSettings.Language = cSharpRadioButton.Checked ? Language.CSharp : Language.VB;

            var validationStyle = ValidationStyle.None;
            if (dataAnnotationsRadioButton.Checked) validationStyle = ValidationStyle.Microsoft;
            if (nhibernateValidationRadioButton.Checked) validationStyle = ValidationStyle.Nhibernate;

            applicationSettings.ValidationStyle = validationStyle;
            applicationSettings.IsFluent = fluentMappingOption.Checked;
            applicationSettings.IsEntityFramework = entityFrameworkRadionBtn.Checked;
            applicationSettings.IsAutoProperty = autoPropertyRadioBtn.Checked;
            applicationSettings.FolderPath = DomainFolderTextBox.Text;
            applicationSettings.DomainFolderPath = IReposityFolderTextBox.Text;
            applicationSettings.InheritenceAndInterfaces = textBoxInheritence.Text;
            applicationSettings.ForeignEntityCollectionType = comboBoxForeignCollection.Text;
            applicationSettings.FieldPrefixRemovalList = applicationSettings.FieldPrefixRemovalList;
            applicationSettings.FieldNamingConvention = GetFieldNamingConvention();
            applicationSettings.Prefix = prefixTextBox.Text;
            applicationSettings.IsCastle = IsCastle;
            applicationSettings.ClassNamePrefix = textBoxClassNamePrefix.Text;
            applicationSettings.EnableInflections = EnableInflectionsCheckBox.Checked;
            applicationSettings.GeneratePartialClasses = partialClassesCheckBox.Checked;
            applicationSettings.GenerateWcfContracts = wcfDataContractCheckBox.Checked;
            applicationSettings.GenerateInFolders = generateInFoldersCheckBox.Checked;
            applicationSettings.IsByCode = IsByCode;
            applicationSettings.UseLazy = useLazyLoadingCheckBox.Checked;
            applicationSettings.IncludeForeignKeys = includeForeignKeysCheckBox.Checked;
            applicationSettings.NameFkAsForeignTable = nameAsForeignTableCheckBox.Checked;
            applicationSettings.IncludeHasMany = includeHasManyCheckBox.Checked;
            applicationSettings.IncludeLengthAndScale = includeLengthAndScaleCheckBox.Checked;
            applicationSettings.LastUsedConnection = _currentConnection == null ? (Guid?)null : _currentConnection.Id;
            CaptureMySetting();
        }

        private void BindData()
        {
            columnName.DataPropertyName = "Name";
            isPrimaryKey.DataPropertyName = "IsPrimaryKey";
            isForeignKey.DataPropertyName = "IsForeignKey";
            isUniqueKey.DataPropertyName = "IsUnique";
            isNullable.DataPropertyName = "IsNullable";
            columnDataType.DataPropertyName = "DataType";
            cSharpType.DataPropertyName = "MappedDataType";
            cSharpType.DataSource = new DotNetTypes();
        }

        private void OwnersSelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                PopulateTablesAndSequences();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void TablesListSelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (tablesListBox.SelectedIndex == -1)
                {
                    dbTableDetailsGridView.DataSource = new List<Column>();
                    return;
                }

                var lastTableSelectedIndex = LastTableSelected();
                if (lastTableSelectedIndex != null)
                {
                    var table = tablesListBox.Items[lastTableSelectedIndex.Value] as Table;

                    if (table != null)
                    {
                        //  CaptureApplicationSettings();

                        PopulateTableDetails(table);

                        //  ToggleColumnsBasedOnAppSettings(applicationSettings);

                        //  GenerateAndDisplayCode(table);

                        //// Display entity name based on formatted table name
                        //var appPreferences = GetApplicationPreferences(table, false, applicationSettings);
                        //var formatter = TextFormatterFactory.GetTextFormatter(appPreferences);
                        ////  entityNameTextBox.Text = formatter.FormatText(table.Name);

                        metadataReader.GetTableDetails(table, ownersComboBox.SelectedItem.ToString());
                        CaptureMySetting();
                        Generate(table);
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = ex.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        readonly IList<int> _cachedTableListSelection = new List<int>();
        private Table _currentTable;

        private int? LastTableSelected()
        {
            int? lastTableIndex = null;
            foreach (int i in tablesListBox.SelectedIndices)
            {
                if (_cachedTableListSelection.Contains(i))
                    continue;
                lastTableIndex = i;
                break;
            }
            _cachedTableListSelection.Clear();
            foreach (int i in tablesListBox.SelectedIndices)
                _cachedTableListSelection.Add(i);
            return lastTableIndex;
        }

        private void PopulateTableDetails(Table selectedTable)
        {
            toolStripStatusLabel.Text = string.Empty;
            try
            {
                //dbTableDetailsGridView.AutoGenerateColumns = true;
                _currentTable = selectedTable;
                gridData = metadataReader.GetTableDetails(selectedTable, ownersComboBox.SelectedItem.ToString()) ??
                           new List<Column>();

                // Show table details, and toggle columns based on app settings
                dbTableDetailsGridView.SuspendLayout();
                dbTableDetailsGridView.DataSource = gridData;
                dbTableDetailsGridView.ResumeLayout();

            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = ex.Message;
            }
        }

        private void connectBtnClicked(object sender, EventArgs e)
        {
            if (_currentConnection == null)
                return;

            toolStripStatusLabel.Text = string.Format("Connecting to {0}...", _currentConnection.Name);
            statusStrip1.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                tablesListBox.DataSource = null;
                tablesListBox.DisplayMember = "Name";
                sequencesComboBox.Items.Clear();

                metadataReader = MetadataFactory.GetReader(_currentConnection.Type, _currentConnection.ConnectionString);

                toolStripStatusLabel.Text = "Retrieving owners...";
                statusStrip1.Refresh();
                PopulateOwners();

                toolStripStatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = ex.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void PopulateOwners()
        {
            var owners = metadataReader.GetOwners();
            if (owners == null || owners.Count == 0)
            {
                owners = new List<string> { "dbo" };
            }

            tablesListBox.SelectedIndexChanged -= TablesListSelectedIndexChanged;

            ownersComboBox.Items.Clear();
            ownersComboBox.Items.AddRange(owners.ToArray());

            tablesListBox.SelectedIndexChanged += TablesListSelectedIndexChanged;
            ownersComboBox.SelectedIndex = 0;
        }

        private void PopulateTablesAndSequences()
        {
            try
            {
                toolStripStatusLabel.Text = "Retrieving tables...";
                statusStrip1.Refresh();

                if (ownersComboBox.SelectedItem == null)
                {
                    tablesListBox.DataSource = new List<Table>();
                    return;
                }
                _tables = metadataReader.GetTables(ownersComboBox.SelectedItem.ToString());
                tablesListBox.Enabled = false;
                TableFilterTextBox.Enabled = false;
                tablesListBox.DataSource = _tables;
                tablesListBox.DisplayMember = "Name_Description";
                if (_tables != null && _tables.Any())
                {
                    tablesListBox.Enabled = true;
                    TableFilterTextBox.Enabled = true;
                    tablesListBox.SelectedItem = _tables.FirstOrDefault();
                }

                var sequences = metadataReader.GetSequences(ownersComboBox.SelectedItem.ToString());
                sequencesComboBox.Enabled = false;
                sequencesComboBox.Items.Clear();
                if (sequences != null && sequences.Any())
                {
                    sequencesComboBox.Items.AddRange(sequences.ToArray());
                    sequencesComboBox.Enabled = true;
                    sequencesComboBox.SelectedIndex = 0;
                }

                toolStripStatusLabel.Text = string.Empty;
                statusStrip1.Refresh();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = ex.Message;
            }
        }

        private void folderSelectButton_Click(object sender, EventArgs e)
        {
            var diagResult = openFileDialog1.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                DomainFolderTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void domainFolderSelectButton_Click(object sender, EventArgs e)
        {
            var diagResult = openFileDialog1.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                if (((Button)sender).Name == domainFolderSelectButton.Name)
                    IReposityFolderTextBox.Text = openFileDialog1.FileName;
                else
                    ReposityFolderTextBox.Text = openFileDialog1.FileName;
            }
        }

        void CaptureMySetting()
        {
            if (mySetting == null)
                mySetting = new MySetting();
            mySetting.IsAggregateRoot = checkBox1.Checked;
            mySetting.IsIgnoreNull = checkBox2.Checked;
            mySetting.IsReWroteCsFile = checkBox3.Checked;
            mySetting.IReposityFolderPath = IReposityFolderTextBox.Text;
            mySetting.IReposityNamespace = IReposityNamespaceTextBox.Text;
            mySetting.ReposityFolderPath = ReposityFolderTextBox.Text;
            mySetting.ReposityNamespace = ReposityNamespaceTextBox.Text;
            mySetting.DominFolderPath = DomainFolderTextBox.Text;
            mySetting.DominNamespace = DomainNmespaceTextBox.Text;
            mySetting.DbConnectionName = connectionNameComboBox.Text;

            mySetting.DomainDir = textBox1.Text.Trim();
            mySetting.IReposityDir = textBox2.Text.Trim();
            mySetting.ReposityDir = textBox3.Text.Trim();
            mySetting.IsUseDir = checkBox5.Checked;
        }
        private void GenerateClicked(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Empty;
            var selectedItems = tablesListBox.SelectedItems;
            if (selectedItems.Count == 0)
            {
                toolStripStatusLabel.Text = @"Please select table(s) above to generate the mapping files.";
                return;
            }
            try
            {
                foreach (var selectedItem in selectedItems)
                {
                    toolStripStatusLabel.Text = string.Format("Generating {0} mapping file ...", selectedItem);
                    var table = (Table)selectedItem;
                    metadataReader.GetTableDetails(table, ownersComboBox.SelectedItem.ToString());
                    // CaptureApplicationSettings();
                    CaptureMySetting();
                    //  Generate(table, selectedItems.Count > 1, applicationSettings);
                    Generate(table, true);
                }
                toolStripStatusLabel.Text = @"Generated all files successfully.";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = ex.Message;
            }
        }
        void Generate(Table tb, bool isToFile = false)
        {
            //生成domain.cs
            string domainCs = CodeMaker.MakeDomainCs(tb, mySetting);
            //生成domain.designer.cs
            string domainDesignerCs = CodeMaker.MakeDomainDesignerCs(tb, mySetting);
            //生成IReposity
            string ireposityCs = CodeMaker.MakeIReposityCs(tb, mySetting);
            //生成Reposity.cs
            string reposityCs = CodeMaker.MakeReposityCs(tb, mySetting);
            //生成Reposity.designer.cs
            string reposityDesignerCs = CodeMaker.MakeReposityDesignerCs(tb, mySetting);
            if (!isToFile)
            {
                domainCodeFastColoredTextBox.Text = domainCs;
                fastColoredTextBox1.Text = domainDesignerCs;
                if (mySetting.IsAggregateRoot)
                {
                    fastColoredTextBox2.Text = ireposityCs;
                    fastColoredTextBox3.Text = reposityCs;
                    fastColoredTextBox4.Text = reposityDesignerCs;
                }
                else
                {
                    //不是聚合根不必要生成仓储类
                    fastColoredTextBox2.Text = "";
                    fastColoredTextBox3.Text = "";
                    fastColoredTextBox4.Text = "";
                }
            }
            else
            {
                //先修改项目文件
                UpdateCsprojFile(mySetting.DominFolderPath, Path.Combine(mySetting.DomainDir, tb.ClassName + ".cs"), Path.Combine(mySetting.DomainDir, tb.ClassName + ".designer.cs"));
                WriteToFile(Path.Combine(Path.GetDirectoryName(mySetting.DominFolderPath), mySetting.DomainDir), tb.ClassName + ".cs", domainCs, mySetting.IsReWroteCsFile);
                WriteToFile(Path.Combine(Path.GetDirectoryName(mySetting.DominFolderPath), mySetting.DomainDir), tb.ClassName + ".designer.cs", domainDesignerCs, true);
                if (mySetting.IsAggregateRoot)
                {
                    //聚合根才要生成仓储类
                    //修改项目文件
                    UpdateCsprojFile(mySetting.IReposityFolderPath, Path.Combine(mySetting.IReposityDir, "I" + tb.ClassName + "Repository.cs"), null);
                    UpdateCsprojFile(mySetting.ReposityFolderPath, Path.Combine(mySetting.ReposityDir, tb.ClassName + "Repository.cs"), Path.Combine(mySetting.ReposityDir, tb.ClassName + "Repository.designer.cs"));

                    WriteToFile(Path.Combine(Path.GetDirectoryName(mySetting.IReposityFolderPath), mySetting.IReposityDir), "I" + tb.ClassName + "Repository.cs", ireposityCs, mySetting.IsReWroteCsFile);
                    WriteToFile(Path.Combine(Path.GetDirectoryName(mySetting.ReposityFolderPath), mySetting.ReposityDir), tb.ClassName + "Repository.cs", reposityCs, mySetting.IsReWroteCsFile);
                    WriteToFile(Path.Combine(Path.GetDirectoryName(mySetting.ReposityFolderPath), mySetting.ReposityDir), tb.ClassName + "Repository.designer.cs", reposityDesignerCs, true);
                }
            }
        }
        void UpdateCsprojFile(string path, string csFile, string designerFile = null)
        {
            //读XML
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            //取节点ItemGroup
            var itemGroupNodeLis = doc.GetElementsByTagName("ItemGroup");
            if (itemGroupNodeLis.Count > 2)
            {
                XmlNode itemGroupNode = itemGroupNodeLis[1];
                //添加cs
                XmlNode compileNode = IsExistsCompileNode(itemGroupNode.ChildNodes, csFile);
                if (compileNode == null)
                {
                    compileNode = doc.CreateNode(XmlNodeType.Element, "Compile", doc.DocumentElement.NamespaceURI);
                    var attr = doc.CreateAttribute("Include");
                    attr.Value = csFile;
                    compileNode.Attributes.Append(attr);
                    itemGroupNode.AppendChild(compileNode);
                }
                //desinger.cs
                if (string.IsNullOrEmpty(designerFile))
                {
                    doc.Save(path);
                    return;
                }
                XmlNode designerCompileNode = IsExistsCompileNode(itemGroupNode.ChildNodes, designerFile);
                if (designerCompileNode == null)
                {
                    designerCompileNode = doc.CreateNode(XmlNodeType.Element, "Compile", doc.DocumentElement.NamespaceURI);
                    var attr = doc.CreateAttribute("Include");
                    attr.Value = designerFile;
                    designerCompileNode.Attributes.Append(attr);
                    itemGroupNode.AppendChild(designerCompileNode);

                    var dependentUponNode = doc.CreateNode(XmlNodeType.Element, "DependentUpon", doc.DocumentElement.NamespaceURI);
                    dependentUponNode.InnerText = Path.GetFileName(csFile);
                    designerCompileNode.AppendChild(dependentUponNode);
                }
                doc.Save(path);
            }
        }
        XmlNode IsExistsCompileNode(XmlNodeList nodes, string includeValue)
        {
            foreach (XmlNode compileNode in nodes)
            {
                if (compileNode.Attributes["Include"].Value == includeValue)
                {
                    return compileNode;
                }
            }
            return null;
        }
        void WriteToFile(string folder, string fileName, string content, bool isCover = true)
        {
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, fileName);
            if (!isCover && File.Exists(path))
                return;
            FileStream fs = new FileStream(path, FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(content);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        private void GenerateAllClicked(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Empty;
            var items = tablesListBox.Items;
            if (items.Count == 0)
            {
                toolStripStatusLabel.Text = @"Please connect to a database to populate the tables first.";
                return;
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    toolStripProgressBar1.Maximum = 100;
                    toolStripProgressBar1.Value = 10;
                    worker.DoWork += DoWork;
                    worker.RunWorkerCompleted += WorkerCompleted;
                    CaptureApplicationSettings();
                    worker.RunWorkerAsync(applicationSettings);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = ex.Message;
            }
        }

        private void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Value = 100;
            toolStripStatusLabel.Text = @"Generated all files successfully.";
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            var appSettings = e.Argument as ApplicationSettings;
            var items = tablesListBox.Items;
            var pOptions = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount };
            Parallel.ForEach(items.Cast<Table>(), pOptions, (table, loopState) =>
            {
                if (worker != null && worker.CancellationPending && !loopState.IsStopped)
                {
                    loopState.Stop();
                    loopState.Break();
                    Thread.Sleep(1000);
                }
                string name = "";
                if (ownersComboBox.InvokeRequired)
                {
                    ownersComboBox.Invoke(new MethodInvoker(delegate
                    {
                        name = ownersComboBox.SelectedItem.ToString();
                    }));
                }
                else
                {
                    name = ownersComboBox.SelectedItem.ToString();
                }
                metadataReader.GetTableDetails(table, name);
                Generate(table, true);
            });
        }

        private void Generate(Table table, bool generateAll, ApplicationSettings appSettings)
        {
            var applicationPreferences = GetApplicationPreferences(table, generateAll, appSettings);
            new ApplicationController(applicationPreferences, table).Generate();
        }

        private void prefixCheckChanged(object sender, EventArgs e)
        {
            prefixLabel.Visible = prefixTextBox.Visible = prefixRadioButton.Checked;
        }

        private ApplicationPreferences GetApplicationPreferences(Table tableName, bool all, ApplicationSettings appSettings)
        {
            string sequence = string.Empty;
            object sequenceName = null;
            if (sequencesComboBox.InvokeRequired)
            {
                sequencesComboBox.Invoke(new MethodInvoker(delegate
                {
                    sequenceName = sequencesComboBox.SelectedItem;
                }));
            }
            else
            {
                sequenceName = sequencesComboBox.SelectedItem;
            }
            if (sequenceName != null && !all)
            {
                sequence = sequenceName.ToString();
            }

            var folderPath = AddSlashToFolderPath(DomainFolderTextBox.Text);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            var domainFolderPath = AddSlashToFolderPath(IReposityFolderTextBox.Text);
            if (appSettings.GenerateInFolders)
            {
                Directory.CreateDirectory(folderPath + "Contract");
                Directory.CreateDirectory(folderPath + "Domain");
                Directory.CreateDirectory(folderPath + "Mapping");
                domainFolderPath = folderPath;
            }
            else
            {
                // Domain folder is specified by user
                if (!Directory.Exists(domainFolderPath))
                {
                    Directory.CreateDirectory(domainFolderPath);
                }
            }

            var applicationPreferences = new ApplicationPreferences
            {
                ServerType = _currentConnection.Type,
                FolderPath = folderPath,
                DomainFolderPath = domainFolderPath,
                TableName = tableName.Name,
                NameSpaceMap = IReposityNamespaceTextBox.Text,
                NameSpace = DomainNmespaceTextBox.Text,
                AssemblyName = ReposityNamespaceTextBox.Text,
                Sequence = sequence,
                Language = LanguageSelected,
                FieldNamingConvention = GetFieldNamingConvention(),
                FieldGenerationConvention = GetFieldGenerationConvention(),
                Prefix = prefixTextBox.Text,
                IsFluent = IsFluent,
                IsEntityFramework = IsEntityFramework,
                IsCastle = IsCastle,
                GeneratePartialClasses = appSettings.GeneratePartialClasses,
                GenerateWcfDataContract = appSettings.GenerateWcfContracts,
                ConnectionString = _currentConnection.ConnectionString,
                ForeignEntityCollectionType = appSettings.ForeignEntityCollectionType,
                InheritenceAndInterfaces = appSettings.InheritenceAndInterfaces,
                GenerateInFolders = appSettings.GenerateInFolders,
                ClassNamePrefix = appSettings.ClassNamePrefix,
                EnableInflections = appSettings.EnableInflections,
                IsByCode = appSettings.IsByCode,
                UseLazy = appSettings.UseLazy,
                FieldPrefixRemovalList = appSettings.FieldPrefixRemovalList,
                IncludeForeignKeys = appSettings.IncludeForeignKeys,
                NameFkAsForeignTable = appSettings.NameFkAsForeignTable,
                IncludeHasMany = appSettings.IncludeHasMany,
                IncludeLengthAndScale = appSettings.IncludeLengthAndScale,
                ValidatorStyle = appSettings.ValidationStyle
            };

            return applicationPreferences;
        }

        private FieldGenerationConvention GetFieldGenerationConvention()
        {
            var convention = FieldGenerationConvention.Field;
            if (autoPropertyRadioBtn.Checked)
                convention = FieldGenerationConvention.AutoProperty;
            if (propertyRadioBtn.Checked)
                convention = FieldGenerationConvention.Property;
            return convention;
        }

        private FieldNamingConvention GetFieldNamingConvention()
        {
            var convention = FieldNamingConvention.SameAsDatabase;
            if (prefixRadioButton.Checked)
                convention = FieldNamingConvention.Prefixed;
            if (camelCasedRadioButton.Checked)
                convention = FieldNamingConvention.CamelCase;
            if (pascalCasedRadioButton.Checked)
                convention = FieldNamingConvention.PascalCase;
            return convention;
        }

        private static string AddSlashToFolderPath(string folderPath)
        {
            if (!folderPath.EndsWith(Path.DirectorySeparatorChar.ToString(CultureInfo.InvariantCulture)))
            {
                folderPath += Path.DirectorySeparatorChar;
            }
            return folderPath;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (worker != null)
            {
                worker.CancelAsync();
            }
        }

        private void OnTableFilterTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox == null) return;

            // Display the full table list
            if (string.IsNullOrEmpty(textbox.Text))
            {
                SuspendLayout();
                tablesListBox.ClearSelected();
                tablesListBox.DataSource = _tables;
                tablesListBox.SelectedItem = _tables.FirstOrDefault();
                ResumeLayout();
                return;
            }

            // Display filtered list of tables
            var query = (from t in _tables
                         where t.Name.ToLower().Contains(textbox.Text.ToLower())
                         select t).ToList();

            SuspendLayout();
            tablesListBox.ClearSelected();
            tablesListBox.DataSource = query;
            tablesListBox.SelectedItem = query.FirstOrDefault();
            ResumeLayout();
        }

        private void OnTableFilterEnter(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (textbox == null) return;

            if (textbox.Text == textbox.Tag.ToString())
            {
                textbox.TextChanged -= OnTableFilterTextChanged;

                // Clear the hint text in the table filter textbox
                textbox.Text = string.Empty;

                textbox.TextChanged += OnTableFilterTextChanged;
            }
        }

        private void OnAddFieldPrefixButtonClick(object sender, EventArgs e)
        {
            // Check if the prefix has already been added.
            if (applicationSettings.FieldPrefixRemovalList.Any(s => s == fieldPrefixTextBox.Text))
            {
                fieldPrefixTextBox.Text = string.Empty;
                return;
            }

            if (string.IsNullOrEmpty(fieldPrefixTextBox.Text)) return;

            // Add the new prefix
            applicationSettings.FieldPrefixRemovalList.Add(fieldPrefixTextBox.Text);
            fieldPrefixListBox.Items.Clear();
            fieldPrefixListBox.Items.AddRange(applicationSettings.FieldPrefixRemovalList.ToArray());
            fieldPrefixTextBox.Text = string.Empty;
        }

        private void OnRemoveFieldPrefixButtonClick(object sender, EventArgs e)
        {
            if (fieldPrefixListBox.SelectedIndex == -1) return;

            applicationSettings.FieldPrefixRemovalList.Remove(fieldPrefixListBox.SelectedItem.ToString());
            fieldPrefixListBox.Items.Clear();
            fieldPrefixListBox.Items.AddRange(applicationSettings.FieldPrefixRemovalList.ToArray());
            fieldPrefixListBox.SelectedIndex = -1;
            removeFieldPrefixButton.Enabled = fieldPrefixListBox.SelectedIndex != -1;
        }

        private void OnFieldPrefixListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            removeFieldPrefixButton.Enabled = fieldPrefixListBox.SelectedIndex != -1;
        }

        public void GenerateAndDisplayCode(Table table)
        {
            SetCodeControlFormatting(applicationSettings);

            // Refresh the primary key relationships.
            table.PrimaryKey = metadataReader.DeterminePrimaryKeys(table);
            table.ForeignKeys = metadataReader.DetermineForeignKeyReferences(table);

            // Show map and domain code preview
            ApplicationPreferences applicationPreferences = GetApplicationPreferences(table, false, applicationSettings);
            var applicationController = new ApplicationController(applicationPreferences, table);
            applicationController.Generate(false);
            //  mapCodeFastColoredTextBox.Text = applicationController.GeneratedMapCode;
            domainCodeFastColoredTextBox.Text = applicationController.GeneratedDomainCode;
        }

        private void includeForeignKeysCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nameAsForeignTableCheckBox.Enabled = includeForeignKeysCheckBox.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var diagResult = folderBrowserDialog.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                try
                {
                    string folder = folderBrowserDialog.SelectedPath;
                    var content = CodeMaker.MakeDbConfig(applicationSettings.Connections, checkBox4.Checked);
                    WriteToFile(folder, "db.config", content, true);
                    toolStripStatusLabel.Text = @"Generated db.config files successfully.";
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel.Text = @"Generated db.config files failed.:" + ex.Message;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CaptureApplicationSettings();
            applicationSettings.Save();
            toolStripStatusLabel.Text = @"save config successed";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            textBox3.Text = textBox1.Text;
        }
    }
}