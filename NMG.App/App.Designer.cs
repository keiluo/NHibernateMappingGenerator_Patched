using System.Drawing;
using System.Windows.Forms;

namespace NHibernateMappingGenerator
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.dbConnStrLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.sequencesComboBox = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.DomainFolderTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.folderSelectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DomainNmespaceTextBox = new System.Windows.Forms.TextBox();
            this.ReposityNamespaceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.generateAllBtn = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.basicSettingsTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableGroupBox = new System.Windows.Forms.GroupBox();
            this.TableFilterTextBox = new System.Windows.Forms.TextBox();
            this.tablesListBox = new System.Windows.Forms.ListBox();
            this.ownersComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dbTableDetailsGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.domainCodeFastColoredTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox2 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox3 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox4 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox5 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ReposityFolderTextBox = new System.Windows.Forms.TextBox();
            this.IReposityFolderTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.domainFolderSelectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IReposityNamespaceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.connectionNameComboBox = new System.Windows.Forms.ComboBox();
            this.pOracleOnlyOptions = new System.Windows.Forms.Panel();
            this.connectionButton = new System.Windows.Forms.Button();
            this.advanceSettingsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.removeFieldPrefixButton = new System.Windows.Forms.Button();
            this.addFieldPrefixButton = new System.Windows.Forms.Button();
            this.fieldPrefixListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fieldPrefixTextBox = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.generateInFoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBoxForeignCollection = new System.Windows.Forms.ComboBox();
            this.wcfDataContractCheckBox = new System.Windows.Forms.CheckBox();
            this.labelForeignEntity = new System.Windows.Forms.Label();
            this.partialClassesCheckBox = new System.Windows.Forms.CheckBox();
            this.labelCLassNamePrefix = new System.Windows.Forms.Label();
            this.labelInheritence = new System.Windows.Forms.Label();
            this.textBoxClassNamePrefix = new System.Windows.Forms.TextBox();
            this.textBoxInheritence = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nameAsForeignTableCheckBox = new System.Windows.Forms.CheckBox();
            this.includeHasManyCheckBox = new System.Windows.Forms.CheckBox();
            this.includeLengthAndScaleCheckBox = new System.Windows.Forms.CheckBox();
            this.autoPropertyRadioBtn = new System.Windows.Forms.RadioButton();
            this.propertyRadioBtn = new System.Windows.Forms.RadioButton();
            this.fieldRadioBtn = new System.Windows.Forms.RadioButton();
            this.useLazyLoadingCheckBox = new System.Windows.Forms.CheckBox();
            this.includeForeignKeysCheckBox = new System.Windows.Forms.CheckBox();
            this.validationStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.dataAnnotationsRadioButton = new System.Windows.Forms.RadioButton();
            this.noValidationRadioButton = new System.Windows.Forms.RadioButton();
            this.nhibernateValidationRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.entityFrameworkRadionBtn = new System.Windows.Forms.RadioButton();
            this.castleMappingOption = new System.Windows.Forms.RadioButton();
            this.fluentMappingOption = new System.Windows.Forms.RadioButton();
            this.hbmMappingOption = new System.Windows.Forms.RadioButton();
            this.byCodeMappingOption = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vbRadioButton = new System.Windows.Forms.RadioButton();
            this.cSharpRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnableInflectionsCheckBox = new System.Windows.Forms.CheckBox();
            this.pascalCasedRadioButton = new System.Windows.Forms.RadioButton();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.prefixRadioButton = new System.Windows.Forms.RadioButton();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.camelCasedRadioButton = new System.Windows.Forms.RadioButton();
            this.sameAsDBRadioButton = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ForeignKeyColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignKeyTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstraintName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isUniqueKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsIdentity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isForeignKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isPrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cSharpType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.basicSettingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbTableDetailsGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainCodeFastColoredTextBox)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox2)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox3)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox5)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pOracleOnlyOptions.SuspendLayout();
            this.advanceSettingsTabPage.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.validationStyleGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbConnStrLabel
            // 
            this.dbConnStrLabel.AutoSize = true;
            this.dbConnStrLabel.Location = new System.Drawing.Point(2, 14);
            this.dbConnStrLabel.Name = "dbConnStrLabel";
            this.dbConnStrLabel.Size = new System.Drawing.Size(119, 12);
            this.dbConnStrLabel.TabIndex = 1;
            this.dbConnStrLabel.Text = "Database Connection";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(234, 28);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 22);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "&Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtnClicked);
            // 
            // sequencesComboBox
            // 
            this.sequencesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sequencesComboBox.DropDownWidth = 449;
            this.sequencesComboBox.FormattingEnabled = true;
            this.sequencesComboBox.Location = new System.Drawing.Point(6, 14);
            this.sequencesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sequencesComboBox.Name = "sequencesComboBox";
            this.sequencesComboBox.Size = new System.Drawing.Size(449, 20);
            this.sequencesComboBox.TabIndex = 4;
            // 
            // DomainFolderTextBox
            // 
            this.DomainFolderTextBox.Location = new System.Drawing.Point(158, 37);
            this.DomainFolderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DomainFolderTextBox.Name = "DomainFolderTextBox";
            this.DomainFolderTextBox.Size = new System.Drawing.Size(464, 21);
            this.DomainFolderTextBox.TabIndex = 7;
            this.DomainFolderTextBox.Text = "c:\\NHibernate Mapping File Generator";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(158, 186);
            this.generateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(106, 22);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "&Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateClicked);
            // 
            // folderSelectButton
            // 
            this.folderSelectButton.Location = new System.Drawing.Point(628, 36);
            this.folderSelectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folderSelectButton.Name = "folderSelectButton";
            this.folderSelectButton.Size = new System.Drawing.Size(75, 22);
            this.folderSelectButton.TabIndex = 9;
            this.folderSelectButton.Text = "Select";
            this.folderSelectButton.UseVisualStyleBackColor = true;
            this.folderSelectButton.Click += new System.EventHandler(this.folderSelectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select the folder in which the mapping and domain files would be generated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Namespace (Domain) :";
            // 
            // DomainNmespaceTextBox
            // 
            this.DomainNmespaceTextBox.Location = new System.Drawing.Point(158, 111);
            this.DomainNmespaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DomainNmespaceTextBox.Name = "DomainNmespaceTextBox";
            this.DomainNmespaceTextBox.Size = new System.Drawing.Size(464, 21);
            this.DomainNmespaceTextBox.TabIndex = 12;
            this.DomainNmespaceTextBox.Text = "Sample.CustomerService.Domain";
            // 
            // ReposityNamespaceTextBox
            // 
            this.ReposityNamespaceTextBox.Location = new System.Drawing.Point(158, 159);
            this.ReposityNamespaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReposityNamespaceTextBox.Name = "ReposityNamespaceTextBox";
            this.ReposityNamespaceTextBox.Size = new System.Drawing.Size(464, 21);
            this.ReposityNamespaceTextBox.TabIndex = 14;
            this.ReposityNamespaceTextBox.Text = "Sample.CustomerService.Reposity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Select the sequence for the selected table";
            // 
            // generateAllBtn
            // 
            this.generateAllBtn.Location = new System.Drawing.Point(390, 186);
            this.generateAllBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateAllBtn.Name = "generateAllBtn";
            this.generateAllBtn.Size = new System.Drawing.Size(106, 22);
            this.generateAllBtn.TabIndex = 18;
            this.generateAllBtn.Text = "Generate &All";
            this.generateAllBtn.UseVisualStyleBackColor = true;
            this.generateAllBtn.Click += new System.EventHandler(this.GenerateAllClicked);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.basicSettingsTabPage);
            this.mainTabControl.Controls.Add(this.advanceSettingsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1361, 457);
            this.mainTabControl.TabIndex = 19;
            // 
            // basicSettingsTabPage
            // 
            this.basicSettingsTabPage.Controls.Add(this.splitContainer1);
            this.basicSettingsTabPage.Controls.Add(this.groupBox5);
            this.basicSettingsTabPage.Controls.Add(this.groupBox4);
            this.basicSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.basicSettingsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basicSettingsTabPage.Name = "basicSettingsTabPage";
            this.basicSettingsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basicSettingsTabPage.Size = new System.Drawing.Size(1353, 431);
            this.basicSettingsTabPage.TabIndex = 1;
            this.basicSettingsTabPage.Text = "Basic";
            this.basicSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 60);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1347, 153);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 23;
            // 
            // tableGroupBox
            // 
            this.tableGroupBox.Controls.Add(this.TableFilterTextBox);
            this.tableGroupBox.Controls.Add(this.tablesListBox);
            this.tableGroupBox.Controls.Add(this.ownersComboBox);
            this.tableGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGroupBox.Location = new System.Drawing.Point(0, 0);
            this.tableGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableGroupBox.Name = "tableGroupBox";
            this.tableGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableGroupBox.Size = new System.Drawing.Size(326, 149);
            this.tableGroupBox.TabIndex = 21;
            this.tableGroupBox.TabStop = false;
            this.tableGroupBox.Text = "Select Owner and Table(s)";
            // 
            // TableFilterTextBox
            // 
            this.TableFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableFilterTextBox.Location = new System.Drawing.Point(6, 43);
            this.TableFilterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableFilterTextBox.Name = "TableFilterTextBox";
            this.TableFilterTextBox.Size = new System.Drawing.Size(316, 21);
            this.TableFilterTextBox.TabIndex = 7;
            this.TableFilterTextBox.Tag = "Enter table filter here...";
            this.TableFilterTextBox.Text = "Enter table filter here...";
            this.TableFilterTextBox.TextChanged += new System.EventHandler(this.OnTableFilterTextChanged);
            this.TableFilterTextBox.Enter += new System.EventHandler(this.OnTableFilterEnter);
            // 
            // tablesListBox
            // 
            this.tablesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablesListBox.FormattingEnabled = true;
            this.tablesListBox.ItemHeight = 12;
            this.tablesListBox.Location = new System.Drawing.Point(6, 67);
            this.tablesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablesListBox.Name = "tablesListBox";
            this.tablesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.tablesListBox.Size = new System.Drawing.Size(315, 64);
            this.tablesListBox.TabIndex = 6;
            // 
            // ownersComboBox
            // 
            this.ownersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownersComboBox.FormattingEnabled = true;
            this.ownersComboBox.Location = new System.Drawing.Point(6, 18);
            this.ownersComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownersComboBox.Name = "ownersComboBox";
            this.ownersComboBox.Size = new System.Drawing.Size(316, 20);
            this.ownersComboBox.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 147);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dbTableDetailsGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(721, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table Definition";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dbTableDetailsGridView
            // 
            this.dbTableDetailsGridView.AllowUserToAddRows = false;
            this.dbTableDetailsGridView.AllowUserToDeleteRows = false;
            this.dbTableDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbTableDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbTableDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTableDetailsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableDetailsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dbTableDetailsGridView.Location = new System.Drawing.Point(3, 2);
            this.dbTableDetailsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbTableDetailsGridView.Name = "dbTableDetailsGridView";
            this.dbTableDetailsGridView.RowHeadersVisible = false;
            this.dbTableDetailsGridView.Size = new System.Drawing.Size(715, 117);
            this.dbTableDetailsGridView.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.domainCodeFastColoredTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(619, 121);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Domain Code";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // domainCodeFastColoredTextBox
            // 
            this.domainCodeFastColoredTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.domainCodeFastColoredTextBox.BackBrush = null;
            this.domainCodeFastColoredTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.domainCodeFastColoredTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.domainCodeFastColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domainCodeFastColoredTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.domainCodeFastColoredTextBox.IsReplaceMode = false;
            this.domainCodeFastColoredTextBox.Location = new System.Drawing.Point(3, 2);
            this.domainCodeFastColoredTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domainCodeFastColoredTextBox.Name = "domainCodeFastColoredTextBox";
            this.domainCodeFastColoredTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.domainCodeFastColoredTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.domainCodeFastColoredTextBox.Size = new System.Drawing.Size(613, 117);
            this.domainCodeFastColoredTextBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.fastColoredTextBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(619, 121);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Domain.Designer";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(619, 121);
            this.fastColoredTextBox1.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.fastColoredTextBox2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(619, 121);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "IReposity";
            // 
            // fastColoredTextBox2
            // 
            this.fastColoredTextBox2.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox2.BackBrush = null;
            this.fastColoredTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox2.IsReplaceMode = false;
            this.fastColoredTextBox2.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastColoredTextBox2.Name = "fastColoredTextBox2";
            this.fastColoredTextBox2.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox2.Size = new System.Drawing.Size(619, 121);
            this.fastColoredTextBox2.TabIndex = 1;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.fastColoredTextBox3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(619, 121);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Reposity";
            // 
            // fastColoredTextBox3
            // 
            this.fastColoredTextBox3.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox3.BackBrush = null;
            this.fastColoredTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox3.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox3.IsReplaceMode = false;
            this.fastColoredTextBox3.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastColoredTextBox3.Name = "fastColoredTextBox3";
            this.fastColoredTextBox3.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox3.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox3.Size = new System.Drawing.Size(619, 121);
            this.fastColoredTextBox3.TabIndex = 1;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.fastColoredTextBox4);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(619, 121);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "Reposity.Designer";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // fastColoredTextBox4
            // 
            this.fastColoredTextBox4.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox4.BackBrush = null;
            this.fastColoredTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox4.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox4.IsReplaceMode = false;
            this.fastColoredTextBox4.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastColoredTextBox4.Name = "fastColoredTextBox4";
            this.fastColoredTextBox4.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox4.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox4.Size = new System.Drawing.Size(619, 121);
            this.fastColoredTextBox4.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fastColoredTextBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(619, 121);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "db.config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fastColoredTextBox5
            // 
            this.fastColoredTextBox5.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox5.BackBrush = null;
            this.fastColoredTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox5.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox5.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox5.IsReplaceMode = false;
            this.fastColoredTextBox5.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fastColoredTextBox5.Name = "fastColoredTextBox5";
            this.fastColoredTextBox5.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox5.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox5.Size = new System.Drawing.Size(619, 121);
            this.fastColoredTextBox5.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.cancelButton);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.ReposityFolderTextBox);
            this.groupBox5.Controls.Add(this.IReposityFolderTextBox);
            this.groupBox5.Controls.Add(this.DomainFolderTextBox);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.domainFolderSelectButton);
            this.groupBox5.Controls.Add(this.generateAllBtn);
            this.groupBox5.Controls.Add(this.folderSelectButton);
            this.groupBox5.Controls.Add(this.ReposityNamespaceTextBox);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.generateButton);
            this.groupBox5.Controls.Add(this.IReposityNamespaceTextBox);
            this.groupBox5.Controls.Add(this.DomainNmespaceTextBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 213);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1347, 216);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(881, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 12);
            this.label13.TabIndex = 28;
            this.label13.Text = "多级目录写法:dir1\\dir2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(711, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "目录 :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(758, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 21);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(880, 36);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(120, 16);
            this.checkBox5.TabIndex = 23;
            this.checkBox5.Text = "命名空间加上目录";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(628, 165);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 16);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "覆盖.cs文件";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(628, 140);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(192, 16);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "忽略可为空，所有属性皆为非空";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(628, 115);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(420, 16);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "聚合根(继承自AggregateRoot,否则继承自BaseEntity且不需要生成仓储类)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(516, 186);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 22);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cance&l";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "Reposity File :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "IReposity File :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "Domain File :";
            // 
            // ReposityFolderTextBox
            // 
            this.ReposityFolderTextBox.Location = new System.Drawing.Point(158, 86);
            this.ReposityFolderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReposityFolderTextBox.Name = "ReposityFolderTextBox";
            this.ReposityFolderTextBox.Size = new System.Drawing.Size(464, 21);
            this.ReposityFolderTextBox.TabIndex = 7;
            this.ReposityFolderTextBox.Text = "c:\\NHibernate Mapping File Generator";
            // 
            // IReposityFolderTextBox
            // 
            this.IReposityFolderTextBox.Location = new System.Drawing.Point(158, 62);
            this.IReposityFolderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IReposityFolderTextBox.Name = "IReposityFolderTextBox";
            this.IReposityFolderTextBox.Size = new System.Drawing.Size(464, 21);
            this.IReposityFolderTextBox.TabIndex = 7;
            this.IReposityFolderTextBox.Text = "c:\\NHibernate Mapping File Generator";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(834, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 47);
            this.button3.TabIndex = 9;
            this.button3.Text = "保存配置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.domainFolderSelectButton_Click);
            // 
            // domainFolderSelectButton
            // 
            this.domainFolderSelectButton.Location = new System.Drawing.Point(628, 61);
            this.domainFolderSelectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domainFolderSelectButton.Name = "domainFolderSelectButton";
            this.domainFolderSelectButton.Size = new System.Drawing.Size(75, 22);
            this.domainFolderSelectButton.TabIndex = 9;
            this.domainFolderSelectButton.Text = "Select";
            this.domainFolderSelectButton.UseVisualStyleBackColor = true;
            this.domainFolderSelectButton.Click += new System.EventHandler(this.domainFolderSelectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Namespace (Reposity) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Namespace (IReposity) :";
            // 
            // IReposityNamespaceTextBox
            // 
            this.IReposityNamespaceTextBox.Location = new System.Drawing.Point(158, 135);
            this.IReposityNamespaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IReposityNamespaceTextBox.Name = "IReposityNamespaceTextBox";
            this.IReposityNamespaceTextBox.Size = new System.Drawing.Size(464, 21);
            this.IReposityNamespaceTextBox.TabIndex = 12;
            this.IReposityNamespaceTextBox.Text = "Sample.CustomerService.IReposity";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.connectionNameComboBox);
            this.groupBox4.Controls.Add(this.pOracleOnlyOptions);
            this.groupBox4.Controls.Add(this.dbConnStrLabel);
            this.groupBox4.Controls.Add(this.connectionButton);
            this.groupBox4.Controls.Add(this.connectBtn);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1347, 58);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(367, 14);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 16);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "加密连接";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 24);
            this.button2.TabIndex = 22;
            this.button2.Text = "生成配置文件到...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectionNameComboBox
            // 
            this.connectionNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectionNameComboBox.FormattingEnabled = true;
            this.connectionNameComboBox.Location = new System.Drawing.Point(6, 29);
            this.connectionNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectionNameComboBox.Name = "connectionNameComboBox";
            this.connectionNameComboBox.Size = new System.Drawing.Size(187, 20);
            this.connectionNameComboBox.Sorted = true;
            this.connectionNameComboBox.TabIndex = 21;
            // 
            // pOracleOnlyOptions
            // 
            this.pOracleOnlyOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pOracleOnlyOptions.Controls.Add(this.label5);
            this.pOracleOnlyOptions.Controls.Add(this.sequencesComboBox);
            this.pOracleOnlyOptions.Location = new System.Drawing.Point(1115, 14);
            this.pOracleOnlyOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pOracleOnlyOptions.Name = "pOracleOnlyOptions";
            this.pOracleOnlyOptions.Size = new System.Drawing.Size(226, 40);
            this.pOracleOnlyOptions.TabIndex = 20;
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(198, 28);
            this.connectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(30, 22);
            this.connectionButton.TabIndex = 2;
            this.connectionButton.Text = "...";
            this.connectionButton.UseVisualStyleBackColor = true;
            // 
            // advanceSettingsTabPage
            // 
            this.advanceSettingsTabPage.Controls.Add(this.groupBox10);
            this.advanceSettingsTabPage.Controls.Add(this.groupBox9);
            this.advanceSettingsTabPage.Controls.Add(this.groupBox8);
            this.advanceSettingsTabPage.Controls.Add(this.groupBox7);
            this.advanceSettingsTabPage.Controls.Add(this.validationStyleGroupBox);
            this.advanceSettingsTabPage.Controls.Add(this.groupBox3);
            this.advanceSettingsTabPage.Controls.Add(this.groupBox2);
            this.advanceSettingsTabPage.Controls.Add(this.groupBox1);
            this.advanceSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.advanceSettingsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.advanceSettingsTabPage.Name = "advanceSettingsTabPage";
            this.advanceSettingsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.advanceSettingsTabPage.Size = new System.Drawing.Size(1251, 431);
            this.advanceSettingsTabPage.TabIndex = 2;
            this.advanceSettingsTabPage.Text = "Preferences";
            this.advanceSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.removeFieldPrefixButton);
            this.groupBox10.Controls.Add(this.addFieldPrefixButton);
            this.groupBox10.Controls.Add(this.fieldPrefixListBox);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.fieldPrefixTextBox);
            this.groupBox10.Location = new System.Drawing.Point(527, 140);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Size = new System.Drawing.Size(309, 205);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Table and Field Formatting";
            // 
            // removeFieldPrefixButton
            // 
            this.removeFieldPrefixButton.Location = new System.Drawing.Point(236, 65);
            this.removeFieldPrefixButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeFieldPrefixButton.Name = "removeFieldPrefixButton";
            this.removeFieldPrefixButton.Size = new System.Drawing.Size(64, 22);
            this.removeFieldPrefixButton.TabIndex = 7;
            this.removeFieldPrefixButton.Text = "Remove";
            this.removeFieldPrefixButton.UseVisualStyleBackColor = true;
            this.removeFieldPrefixButton.Click += new System.EventHandler(this.OnRemoveFieldPrefixButtonClick);
            // 
            // addFieldPrefixButton
            // 
            this.addFieldPrefixButton.Location = new System.Drawing.Point(236, 38);
            this.addFieldPrefixButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFieldPrefixButton.Name = "addFieldPrefixButton";
            this.addFieldPrefixButton.Size = new System.Drawing.Size(64, 22);
            this.addFieldPrefixButton.TabIndex = 7;
            this.addFieldPrefixButton.Text = "Add";
            this.addFieldPrefixButton.UseVisualStyleBackColor = true;
            this.addFieldPrefixButton.Click += new System.EventHandler(this.OnAddFieldPrefixButtonClick);
            // 
            // fieldPrefixListBox
            // 
            this.fieldPrefixListBox.FormattingEnabled = true;
            this.fieldPrefixListBox.ItemHeight = 12;
            this.fieldPrefixListBox.Location = new System.Drawing.Point(19, 65);
            this.fieldPrefixListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fieldPrefixListBox.Name = "fieldPrefixListBox";
            this.fieldPrefixListBox.Size = new System.Drawing.Size(210, 124);
            this.fieldPrefixListBox.TabIndex = 6;
            this.fieldPrefixListBox.SelectedIndexChanged += new System.EventHandler(this.OnFieldPrefixListBoxSelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Remove the following prefixes from field and table names.";
            // 
            // fieldPrefixTextBox
            // 
            this.fieldPrefixTextBox.Location = new System.Drawing.Point(19, 40);
            this.fieldPrefixTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fieldPrefixTextBox.Name = "fieldPrefixTextBox";
            this.fieldPrefixTextBox.Size = new System.Drawing.Size(210, 21);
            this.fieldPrefixTextBox.TabIndex = 4;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.generateInFoldersCheckBox);
            this.groupBox9.Location = new System.Drawing.Point(212, 140);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(309, 34);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Files";
            // 
            // generateInFoldersCheckBox
            // 
            this.generateInFoldersCheckBox.AutoSize = true;
            this.generateInFoldersCheckBox.Location = new System.Drawing.Point(12, 13);
            this.generateInFoldersCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateInFoldersCheckBox.Name = "generateInFoldersCheckBox";
            this.generateInFoldersCheckBox.Size = new System.Drawing.Size(216, 16);
            this.generateInFoldersCheckBox.TabIndex = 0;
            this.generateInFoldersCheckBox.Text = "Group generated files in folders";
            this.generateInFoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBoxForeignCollection);
            this.groupBox8.Controls.Add(this.wcfDataContractCheckBox);
            this.groupBox8.Controls.Add(this.labelForeignEntity);
            this.groupBox8.Controls.Add(this.partialClassesCheckBox);
            this.groupBox8.Controls.Add(this.labelCLassNamePrefix);
            this.groupBox8.Controls.Add(this.labelInheritence);
            this.groupBox8.Controls.Add(this.textBoxClassNamePrefix);
            this.groupBox8.Controls.Add(this.textBoxInheritence);
            this.groupBox8.Location = new System.Drawing.Point(212, 179);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(309, 193);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Mapping Options";
            // 
            // comboBoxForeignCollection
            // 
            this.comboBoxForeignCollection.AllowDrop = true;
            this.comboBoxForeignCollection.FormattingEnabled = true;
            this.comboBoxForeignCollection.Items.AddRange(new object[] {
            "IList",
            "ICollection",
            "Iesi.Collections.Generic.ISet"});
            this.comboBoxForeignCollection.Location = new System.Drawing.Point(15, 116);
            this.comboBoxForeignCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxForeignCollection.Name = "comboBoxForeignCollection";
            this.comboBoxForeignCollection.Size = new System.Drawing.Size(193, 20);
            this.comboBoxForeignCollection.TabIndex = 20;
            // 
            // wcfDataContractCheckBox
            // 
            this.wcfDataContractCheckBox.AutoSize = true;
            this.wcfDataContractCheckBox.Location = new System.Drawing.Point(13, 80);
            this.wcfDataContractCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wcfDataContractCheckBox.Name = "wcfDataContractCheckBox";
            this.wcfDataContractCheckBox.Size = new System.Drawing.Size(186, 16);
            this.wcfDataContractCheckBox.TabIndex = 1;
            this.wcfDataContractCheckBox.Text = "Generate WCF Data Contracts";
            this.wcfDataContractCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelForeignEntity
            // 
            this.labelForeignEntity.AutoSize = true;
            this.labelForeignEntity.Location = new System.Drawing.Point(12, 102);
            this.labelForeignEntity.Name = "labelForeignEntity";
            this.labelForeignEntity.Size = new System.Drawing.Size(251, 12);
            this.labelForeignEntity.TabIndex = 6;
            this.labelForeignEntity.Text = "Preferred Foreign Entity Collection Type:";
            // 
            // partialClassesCheckBox
            // 
            this.partialClassesCheckBox.AutoSize = true;
            this.partialClassesCheckBox.Location = new System.Drawing.Point(13, 59);
            this.partialClassesCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partialClassesCheckBox.Name = "partialClassesCheckBox";
            this.partialClassesCheckBox.Size = new System.Drawing.Size(168, 16);
            this.partialClassesCheckBox.TabIndex = 0;
            this.partialClassesCheckBox.Text = "Generate Partial Classes";
            this.partialClassesCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelCLassNamePrefix
            // 
            this.labelCLassNamePrefix.AutoSize = true;
            this.labelCLassNamePrefix.Location = new System.Drawing.Point(12, 145);
            this.labelCLassNamePrefix.Name = "labelCLassNamePrefix";
            this.labelCLassNamePrefix.Size = new System.Drawing.Size(113, 12);
            this.labelCLassNamePrefix.TabIndex = 5;
            this.labelCLassNamePrefix.Text = "Class Name Prefix:";
            // 
            // labelInheritence
            // 
            this.labelInheritence.AutoSize = true;
            this.labelInheritence.Location = new System.Drawing.Point(10, 18);
            this.labelInheritence.Name = "labelInheritence";
            this.labelInheritence.Size = new System.Drawing.Size(383, 12);
            this.labelInheritence.TabIndex = 5;
            this.labelInheritence.Text = "Inheritence && Interfaces (e.g. Entity<T>, ISomeInterface<T>):  ";
            // 
            // textBoxClassNamePrefix
            // 
            this.textBoxClassNamePrefix.Location = new System.Drawing.Point(110, 142);
            this.textBoxClassNamePrefix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClassNamePrefix.Name = "textBoxClassNamePrefix";
            this.textBoxClassNamePrefix.Size = new System.Drawing.Size(98, 21);
            this.textBoxClassNamePrefix.TabIndex = 4;
            // 
            // textBoxInheritence
            // 
            this.textBoxInheritence.Location = new System.Drawing.Point(13, 32);
            this.textBoxInheritence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInheritence.Name = "textBoxInheritence";
            this.textBoxInheritence.Size = new System.Drawing.Size(287, 21);
            this.textBoxInheritence.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.nameAsForeignTableCheckBox);
            this.groupBox7.Controls.Add(this.includeHasManyCheckBox);
            this.groupBox7.Controls.Add(this.includeLengthAndScaleCheckBox);
            this.groupBox7.Controls.Add(this.autoPropertyRadioBtn);
            this.groupBox7.Controls.Add(this.propertyRadioBtn);
            this.groupBox7.Controls.Add(this.fieldRadioBtn);
            this.groupBox7.Controls.Add(this.useLazyLoadingCheckBox);
            this.groupBox7.Controls.Add(this.includeForeignKeysCheckBox);
            this.groupBox7.Location = new System.Drawing.Point(6, 140);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(200, 232);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Field Or Property";
            // 
            // nameAsForeignTableCheckBox
            // 
            this.nameAsForeignTableCheckBox.AutoSize = true;
            this.nameAsForeignTableCheckBox.Location = new System.Drawing.Point(29, 124);
            this.nameAsForeignTableCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameAsForeignTableCheckBox.Name = "nameAsForeignTableCheckBox";
            this.nameAsForeignTableCheckBox.Size = new System.Drawing.Size(150, 16);
            this.nameAsForeignTableCheckBox.TabIndex = 11;
            this.nameAsForeignTableCheckBox.Text = "Name as Foreign Table";
            this.nameAsForeignTableCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeHasManyCheckBox
            // 
            this.includeHasManyCheckBox.AutoSize = true;
            this.includeHasManyCheckBox.Location = new System.Drawing.Point(6, 145);
            this.includeHasManyCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.includeHasManyCheckBox.Name = "includeHasManyCheckBox";
            this.includeHasManyCheckBox.Size = new System.Drawing.Size(204, 16);
            this.includeHasManyCheckBox.TabIndex = 10;
            this.includeHasManyCheckBox.Text = "Include \"Has Many\" (Inverse\'s)";
            this.includeHasManyCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeLengthAndScaleCheckBox
            // 
            this.includeLengthAndScaleCheckBox.AutoSize = true;
            this.includeLengthAndScaleCheckBox.Location = new System.Drawing.Point(6, 166);
            this.includeLengthAndScaleCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.includeLengthAndScaleCheckBox.Name = "includeLengthAndScaleCheckBox";
            this.includeLengthAndScaleCheckBox.Size = new System.Drawing.Size(168, 16);
            this.includeLengthAndScaleCheckBox.TabIndex = 9;
            this.includeLengthAndScaleCheckBox.Text = "Include Length and Scale";
            this.includeLengthAndScaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoPropertyRadioBtn
            // 
            this.autoPropertyRadioBtn.AutoSize = true;
            this.autoPropertyRadioBtn.Location = new System.Drawing.Point(6, 60);
            this.autoPropertyRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoPropertyRadioBtn.Name = "autoPropertyRadioBtn";
            this.autoPropertyRadioBtn.Size = new System.Drawing.Size(101, 16);
            this.autoPropertyRadioBtn.TabIndex = 6;
            this.autoPropertyRadioBtn.Text = "Auto Property";
            this.autoPropertyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // propertyRadioBtn
            // 
            this.propertyRadioBtn.AutoSize = true;
            this.propertyRadioBtn.Location = new System.Drawing.Point(6, 38);
            this.propertyRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertyRadioBtn.Name = "propertyRadioBtn";
            this.propertyRadioBtn.Size = new System.Drawing.Size(71, 16);
            this.propertyRadioBtn.TabIndex = 5;
            this.propertyRadioBtn.Text = "Property";
            this.propertyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // fieldRadioBtn
            // 
            this.fieldRadioBtn.AutoSize = true;
            this.fieldRadioBtn.Checked = true;
            this.fieldRadioBtn.Location = new System.Drawing.Point(6, 18);
            this.fieldRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fieldRadioBtn.Name = "fieldRadioBtn";
            this.fieldRadioBtn.Size = new System.Drawing.Size(53, 16);
            this.fieldRadioBtn.TabIndex = 4;
            this.fieldRadioBtn.TabStop = true;
            this.fieldRadioBtn.Text = "Field";
            this.fieldRadioBtn.UseVisualStyleBackColor = true;
            // 
            // useLazyLoadingCheckBox
            // 
            this.useLazyLoadingCheckBox.AutoSize = true;
            this.useLazyLoadingCheckBox.Location = new System.Drawing.Point(6, 82);
            this.useLazyLoadingCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useLazyLoadingCheckBox.Name = "useLazyLoadingCheckBox";
            this.useLazyLoadingCheckBox.Size = new System.Drawing.Size(120, 16);
            this.useLazyLoadingCheckBox.TabIndex = 7;
            this.useLazyLoadingCheckBox.Text = "Use Lazy Loading";
            this.useLazyLoadingCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeForeignKeysCheckBox
            // 
            this.includeForeignKeysCheckBox.AutoSize = true;
            this.includeForeignKeysCheckBox.Location = new System.Drawing.Point(6, 102);
            this.includeForeignKeysCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.includeForeignKeysCheckBox.Name = "includeForeignKeysCheckBox";
            this.includeForeignKeysCheckBox.Size = new System.Drawing.Size(144, 16);
            this.includeForeignKeysCheckBox.TabIndex = 8;
            this.includeForeignKeysCheckBox.Text = "Include Foreign Keys";
            this.includeForeignKeysCheckBox.UseVisualStyleBackColor = true;
            this.includeForeignKeysCheckBox.CheckedChanged += new System.EventHandler(this.includeForeignKeysCheckBox_CheckedChanged);
            // 
            // validationStyleGroupBox
            // 
            this.validationStyleGroupBox.Controls.Add(this.dataAnnotationsRadioButton);
            this.validationStyleGroupBox.Controls.Add(this.noValidationRadioButton);
            this.validationStyleGroupBox.Controls.Add(this.nhibernateValidationRadioButton);
            this.validationStyleGroupBox.Location = new System.Drawing.Point(341, 44);
            this.validationStyleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validationStyleGroupBox.Name = "validationStyleGroupBox";
            this.validationStyleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validationStyleGroupBox.Size = new System.Drawing.Size(181, 90);
            this.validationStyleGroupBox.TabIndex = 6;
            this.validationStyleGroupBox.TabStop = false;
            this.validationStyleGroupBox.Text = "Validation Style";
            // 
            // dataAnnotationsRadioButton
            // 
            this.dataAnnotationsRadioButton.AutoSize = true;
            this.dataAnnotationsRadioButton.Location = new System.Drawing.Point(6, 37);
            this.dataAnnotationsRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataAnnotationsRadioButton.Name = "dataAnnotationsRadioButton";
            this.dataAnnotationsRadioButton.Size = new System.Drawing.Size(149, 16);
            this.dataAnnotationsRadioButton.TabIndex = 5;
            this.dataAnnotationsRadioButton.Text = ".Net Data Annotations";
            this.dataAnnotationsRadioButton.UseVisualStyleBackColor = true;
            // 
            // noValidationRadioButton
            // 
            this.noValidationRadioButton.AutoSize = true;
            this.noValidationRadioButton.Checked = true;
            this.noValidationRadioButton.Location = new System.Drawing.Point(6, 16);
            this.noValidationRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noValidationRadioButton.Name = "noValidationRadioButton";
            this.noValidationRadioButton.Size = new System.Drawing.Size(47, 16);
            this.noValidationRadioButton.TabIndex = 4;
            this.noValidationRadioButton.TabStop = true;
            this.noValidationRadioButton.Text = "None";
            this.noValidationRadioButton.UseVisualStyleBackColor = true;
            // 
            // nhibernateValidationRadioButton
            // 
            this.nhibernateValidationRadioButton.AutoSize = true;
            this.nhibernateValidationRadioButton.Location = new System.Drawing.Point(6, 58);
            this.nhibernateValidationRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhibernateValidationRadioButton.Name = "nhibernateValidationRadioButton";
            this.nhibernateValidationRadioButton.Size = new System.Drawing.Size(149, 16);
            this.nhibernateValidationRadioButton.TabIndex = 4;
            this.nhibernateValidationRadioButton.Text = "NHibernate Validators";
            this.nhibernateValidationRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.entityFrameworkRadionBtn);
            this.groupBox3.Controls.Add(this.castleMappingOption);
            this.groupBox3.Controls.Add(this.fluentMappingOption);
            this.groupBox3.Controls.Add(this.hbmMappingOption);
            this.groupBox3.Controls.Add(this.byCodeMappingOption);
            this.groupBox3.Location = new System.Drawing.Point(527, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(309, 130);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mapping Style";
            // 
            // entityFrameworkRadionBtn
            // 
            this.entityFrameworkRadionBtn.AutoSize = true;
            this.entityFrameworkRadionBtn.Location = new System.Drawing.Point(6, 101);
            this.entityFrameworkRadionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entityFrameworkRadionBtn.Name = "entityFrameworkRadionBtn";
            this.entityFrameworkRadionBtn.Size = new System.Drawing.Size(119, 16);
            this.entityFrameworkRadionBtn.TabIndex = 11;
            this.entityFrameworkRadionBtn.TabStop = true;
            this.entityFrameworkRadionBtn.Text = "Entity Framework";
            this.entityFrameworkRadionBtn.UseVisualStyleBackColor = true;
            // 
            // castleMappingOption
            // 
            this.castleMappingOption.AutoSize = true;
            this.castleMappingOption.Location = new System.Drawing.Point(6, 60);
            this.castleMappingOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.castleMappingOption.Name = "castleMappingOption";
            this.castleMappingOption.Size = new System.Drawing.Size(143, 16);
            this.castleMappingOption.TabIndex = 8;
            this.castleMappingOption.TabStop = true;
            this.castleMappingOption.Text = "Castle Active Record";
            this.castleMappingOption.UseVisualStyleBackColor = true;
            // 
            // fluentMappingOption
            // 
            this.fluentMappingOption.AutoSize = true;
            this.fluentMappingOption.Location = new System.Drawing.Point(6, 38);
            this.fluentMappingOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fluentMappingOption.Name = "fluentMappingOption";
            this.fluentMappingOption.Size = new System.Drawing.Size(107, 16);
            this.fluentMappingOption.TabIndex = 5;
            this.fluentMappingOption.Text = "Fluent Mapping";
            this.fluentMappingOption.UseVisualStyleBackColor = true;
            // 
            // hbmMappingOption
            // 
            this.hbmMappingOption.AutoSize = true;
            this.hbmMappingOption.Checked = true;
            this.hbmMappingOption.Location = new System.Drawing.Point(6, 18);
            this.hbmMappingOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hbmMappingOption.Name = "hbmMappingOption";
            this.hbmMappingOption.Size = new System.Drawing.Size(101, 16);
            this.hbmMappingOption.TabIndex = 4;
            this.hbmMappingOption.TabStop = true;
            this.hbmMappingOption.Text = ".hbm.xml file";
            this.hbmMappingOption.UseVisualStyleBackColor = true;
            // 
            // byCodeMappingOption
            // 
            this.byCodeMappingOption.AutoSize = true;
            this.byCodeMappingOption.Location = new System.Drawing.Point(6, 82);
            this.byCodeMappingOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.byCodeMappingOption.Name = "byCodeMappingOption";
            this.byCodeMappingOption.Size = new System.Drawing.Size(227, 16);
            this.byCodeMappingOption.TabIndex = 10;
            this.byCodeMappingOption.TabStop = true;
            this.byCodeMappingOption.Text = "By Code Mapping (NH3.2 Loquacious)";
            this.byCodeMappingOption.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vbRadioButton);
            this.groupBox2.Controls.Add(this.cSharpRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(340, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(181, 34);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Language";
            // 
            // vbRadioButton
            // 
            this.vbRadioButton.AutoSize = true;
            this.vbRadioButton.Location = new System.Drawing.Point(84, 12);
            this.vbRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbRadioButton.Name = "vbRadioButton";
            this.vbRadioButton.Size = new System.Drawing.Size(35, 16);
            this.vbRadioButton.TabIndex = 5;
            this.vbRadioButton.Text = "VB";
            this.vbRadioButton.UseVisualStyleBackColor = true;
            // 
            // cSharpRadioButton
            // 
            this.cSharpRadioButton.AutoSize = true;
            this.cSharpRadioButton.Checked = true;
            this.cSharpRadioButton.Location = new System.Drawing.Point(6, 12);
            this.cSharpRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cSharpRadioButton.Name = "cSharpRadioButton";
            this.cSharpRadioButton.Size = new System.Drawing.Size(35, 16);
            this.cSharpRadioButton.TabIndex = 4;
            this.cSharpRadioButton.TabStop = true;
            this.cSharpRadioButton.Text = "C#";
            this.cSharpRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnableInflectionsCheckBox);
            this.groupBox1.Controls.Add(this.pascalCasedRadioButton);
            this.groupBox1.Controls.Add(this.prefixTextBox);
            this.groupBox1.Controls.Add(this.prefixRadioButton);
            this.groupBox1.Controls.Add(this.prefixLabel);
            this.groupBox1.Controls.Add(this.camelCasedRadioButton);
            this.groupBox1.Controls.Add(this.sameAsDBRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(328, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generated Property Name";
            // 
            // EnableInflectionsCheckBox
            // 
            this.EnableInflectionsCheckBox.AutoSize = true;
            this.EnableInflectionsCheckBox.Location = new System.Drawing.Point(6, 102);
            this.EnableInflectionsCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnableInflectionsCheckBox.Name = "EnableInflectionsCheckBox";
            this.EnableInflectionsCheckBox.Size = new System.Drawing.Size(288, 16);
            this.EnableInflectionsCheckBox.TabIndex = 22;
            this.EnableInflectionsCheckBox.Text = "Load Inflections to Singularize or Pruralize";
            this.EnableInflectionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // pascalCasedRadioButton
            // 
            this.pascalCasedRadioButton.AutoSize = true;
            this.pascalCasedRadioButton.Location = new System.Drawing.Point(6, 60);
            this.pascalCasedRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pascalCasedRadioButton.Name = "pascalCasedRadioButton";
            this.pascalCasedRadioButton.Size = new System.Drawing.Size(245, 16);
            this.pascalCasedRadioButton.TabIndex = 4;
            this.pascalCasedRadioButton.Text = "Pascal Case (e.g. ThisIsMyColumnName)";
            this.pascalCasedRadioButton.UseVisualStyleBackColor = true;
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(275, 82);
            this.prefixTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(47, 21);
            this.prefixTextBox.TabIndex = 3;
            this.prefixTextBox.Text = "m_";
            // 
            // prefixRadioButton
            // 
            this.prefixRadioButton.AutoSize = true;
            this.prefixRadioButton.Location = new System.Drawing.Point(6, 82);
            this.prefixRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prefixRadioButton.Name = "prefixRadioButton";
            this.prefixRadioButton.Size = new System.Drawing.Size(239, 16);
            this.prefixRadioButton.TabIndex = 2;
            this.prefixRadioButton.Text = "Prefixed (e.g. m_ThisIsMyColumnName)";
            this.prefixRadioButton.UseVisualStyleBackColor = true;
            this.prefixRadioButton.CheckedChanged += new System.EventHandler(this.prefixCheckChanged);
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(227, 85);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(59, 12);
            this.prefixLabel.TabIndex = 2;
            this.prefixLabel.Text = "Prefix : ";
            // 
            // camelCasedRadioButton
            // 
            this.camelCasedRadioButton.AutoSize = true;
            this.camelCasedRadioButton.Location = new System.Drawing.Point(6, 38);
            this.camelCasedRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.camelCasedRadioButton.Name = "camelCasedRadioButton";
            this.camelCasedRadioButton.Size = new System.Drawing.Size(239, 16);
            this.camelCasedRadioButton.TabIndex = 1;
            this.camelCasedRadioButton.Text = "Camel Case (e.g. thisIsMyColumnName)";
            this.camelCasedRadioButton.UseVisualStyleBackColor = true;
            // 
            // sameAsDBRadioButton
            // 
            this.sameAsDBRadioButton.AutoSize = true;
            this.sameAsDBRadioButton.Checked = true;
            this.sameAsDBRadioButton.Location = new System.Drawing.Point(6, 18);
            this.sameAsDBRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sameAsDBRadioButton.Name = "sameAsDBRadioButton";
            this.sameAsDBRadioButton.Size = new System.Drawing.Size(263, 16);
            this.sameAsDBRadioButton.TabIndex = 0;
            this.sameAsDBRadioButton.TabStop = true;
            this.sameAsDBRadioButton.Text = "Same as database column name (No change)";
            this.sameAsDBRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1075, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoToolTip = true;
            this.toolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(758, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
            // 
            // ForeignKeyColumnName
            // 
            this.ForeignKeyColumnName.DataPropertyName = "ForeignKeyColumnName";
            this.ForeignKeyColumnName.HeaderText = "FK Column";
            this.ForeignKeyColumnName.Name = "ForeignKeyColumnName";
            // 
            // ForeignKeyTableName
            // 
            this.ForeignKeyTableName.DataPropertyName = "ForeignKeyTableName";
            this.ForeignKeyTableName.HeaderText = "FK Table";
            this.ForeignKeyTableName.Name = "ForeignKeyTableName";
            // 
            // ConstraintName
            // 
            this.ConstraintName.DataPropertyName = "ConstraintName";
            this.ConstraintName.HeaderText = "Constraint";
            this.ConstraintName.Name = "ConstraintName";
            // 
            // isUniqueKey
            // 
            this.isUniqueKey.HeaderText = "Unique Key";
            this.isUniqueKey.Name = "isUniqueKey";
            // 
            // IsIdentity
            // 
            this.IsIdentity.DataPropertyName = "IsIdentity";
            this.IsIdentity.HeaderText = "Identity";
            this.IsIdentity.Name = "IsIdentity";
            // 
            // isNullable
            // 
            this.isNullable.HeaderText = "Nullable";
            this.isNullable.Name = "isNullable";
            // 
            // isForeignKey
            // 
            this.isForeignKey.HeaderText = "Foreign Key";
            this.isForeignKey.Name = "isForeignKey";
            // 
            // isPrimaryKey
            // 
            this.isPrimaryKey.HeaderText = "Primary Key";
            this.isPrimaryKey.Name = "isPrimaryKey";
            // 
            // cSharpType
            // 
            this.cSharpType.HeaderText = "C# Type";
            this.cSharpType.Name = "cSharpType";
            this.cSharpType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSharpType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnDataType
            // 
            this.columnDataType.HeaderText = "Data Type";
            this.columnDataType.Name = "columnDataType";
            this.columnDataType.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "Name";
            this.columnName.HeaderText = "Column Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "c#项目|*csproj|所有文件|*.*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(758, 61);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 21);
            this.textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(758, 86);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 21);
            this.textBox3.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(711, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "目录 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(711, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "目录 :";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 480);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "App";
            this.Text = "NHibernate Mapping Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTabControl.ResumeLayout(false);
            this.basicSettingsTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableGroupBox.ResumeLayout(false);
            this.tableGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbTableDetailsGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.domainCodeFastColoredTextBox)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox2)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox3)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pOracleOnlyOptions.ResumeLayout(false);
            this.pOracleOnlyOptions.PerformLayout();
            this.advanceSettingsTabPage.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.validationStyleGroupBox.ResumeLayout(false);
            this.validationStyleGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dbConnStrLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox sequencesComboBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox DomainFolderTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button folderSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DomainNmespaceTextBox;
        private System.Windows.Forms.TextBox ReposityNamespaceTextBox;
        private Label label5;
        private Button generateAllBtn;
        private TabControl mainTabControl;
        private TabPage basicSettingsTabPage;
        private TabPage advanceSettingsTabPage;
        private GroupBox groupBox1;
        private RadioButton sameAsDBRadioButton;
        private RadioButton prefixRadioButton;
        private RadioButton camelCasedRadioButton;
        private TextBox prefixTextBox;
        private Label prefixLabel;
        private GroupBox groupBox2;
        private RadioButton vbRadioButton;
        private RadioButton cSharpRadioButton;
        private GroupBox groupBox3;
        private RadioButton fluentMappingOption;
        private RadioButton hbmMappingOption;
        private RadioButton byCodeMappingOption;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox tableGroupBox;
        private GroupBox groupBox7;
        private RadioButton propertyRadioBtn;
        private RadioButton fieldRadioBtn;
        private RadioButton autoPropertyRadioBtn;
        private RadioButton castleMappingOption;
        private ComboBox ownersComboBox;
        private RadioButton pascalCasedRadioButton;
        private GroupBox groupBox8;
        private CheckBox partialClassesCheckBox;
        private Panel pOracleOnlyOptions;
        private Button cancelButton;
        private CheckBox wcfDataContractCheckBox;
        private ListBox tablesListBox;
        private Label labelInheritence;
        private TextBox textBoxInheritence;
        private ComboBox comboBoxForeignCollection;
        private Label labelForeignEntity;
        private Label labelCLassNamePrefix;
        private TextBox textBoxClassNamePrefix;
        private GroupBox groupBox9;
        private CheckBox generateInFoldersCheckBox;
        private CheckBox useLazyLoadingCheckBox;
        private CheckBox includeForeignKeysCheckBox;
        private CheckBox includeLengthAndScaleCheckBox;
        private TextBox TableFilterTextBox;
        private GroupBox groupBox10;
        private Button removeFieldPrefixButton;
        private Button addFieldPrefixButton;
        private ListBox fieldPrefixListBox;
        private Label label7;
        private TextBox fieldPrefixTextBox;
        private ComboBox connectionNameComboBox;
        private Button connectionButton;
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private FastColoredTextBoxNS.FastColoredTextBox domainCodeFastColoredTextBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripProgressBar toolStripProgressBar1;
        private Label label4;
        private TextBox IReposityNamespaceTextBox;
        private Label label9;
        private Label label8;
        private TextBox IReposityFolderTextBox;
        private Button domainFolderSelectButton;
        private GroupBox validationStyleGroupBox;
        private RadioButton dataAnnotationsRadioButton;
        private RadioButton noValidationRadioButton;
        private RadioButton nhibernateValidationRadioButton;
        private CheckBox includeHasManyCheckBox;
        private CheckBox EnableInflectionsCheckBox;
        private CheckBox nameAsForeignTableCheckBox;
        private RadioButton entityFrameworkRadionBtn;
        private TabPage tabPage1;
        private DataGridView dbTableDetailsGridView;
        private TabPage tabPage5;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private DataGridViewTextBoxColumn ForeignKeyColumnName;
        private DataGridViewTextBoxColumn ForeignKeyTableName;
        private DataGridViewTextBoxColumn ConstraintName;
        private DataGridViewCheckBoxColumn isUniqueKey;
        private DataGridViewCheckBoxColumn IsIdentity;
        private DataGridViewCheckBoxColumn isNullable;
        private DataGridViewCheckBoxColumn isForeignKey;
        private DataGridViewCheckBoxColumn isPrimaryKey;
        private DataGridViewComboBoxColumn cSharpType;
        private DataGridViewTextBoxColumn columnDataType;
        private DataGridViewTextBoxColumn columnName;
        private TabPage tabPage9;
        private CheckBox checkBox1;
        private Label label10;
        private TextBox ReposityFolderTextBox;
        private Button button1;
        private Label label3;
        private CheckBox checkBox2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox3;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox4;
        private CheckBox checkBox3;
        private Button button2;
        private CheckBox checkBox4;
        private TabPage tabPage2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox5;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private Label label6;
        private TextBox textBox1;
        private CheckBox checkBox5;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}

