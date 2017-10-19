using NMG.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateMappingGenerator
{
    public class CodeMaker
    {
        public static string MakeDomainCs(Table table, MySetting mySetting)
        {
            string res = string.Format(@"
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
namespace {0}
{{
    public partial class {1}
    {{
   }}
}}", mySetting.DominNamespace+(mySetting.IsUseDir&&!string.IsNullOrEmpty(mySetting.DomainDir) ?"."+mySetting.DomainDir.Replace("\\","."):""), table.ClassName);

            return res;
        }

        public static string MakeDomainDesignerCs(Table table, MySetting mySetting)
        {
            //处理列信息
            string colStr = "";
            for (int i = 0; i < table.Columns.Count; i++)
            {
                Column c = table.Columns[i];
                colStr += string.Format(
@"
       {0}
       {1}
       [TableField]
       [Alias(""{2}"")]
        /// <summary>
        /// {3}
        /// </summary>	
        public {4} {5} {{ get; set; }}
", c.IsPrimaryKey ? "[PrimaryKey]" : ""
 , c.IsIdentity ? "[AutoIncrement]" : ""
 , c.Name
 , c.Description
 , c.MappedDataType + (c.IsNullable && !mySetting.IsIgnoreNull ? "?" : "")
 , c.PropertyName);
            }

            //最终结果
            string res = string.Format(@"
using ServiceStack.DataAnnotations;
using Com.Core;
using ServiceStack.OrmLite.zly;
namespace {0}
{{
    /// <summary>
    /// {2}
    /// </summary>
    [DbLinkName(""{3}"")]
    [Alias(""{4}"")]
    public partial class {1} : {5}
    {{
{6}
    }}
}}", mySetting.DominNamespace + (mySetting.IsUseDir && !string.IsNullOrEmpty(mySetting.DomainDir) ? "." + mySetting.DomainDir.Replace("\\", ".") : "")
      , table.ClassName
      , table.Description
      , mySetting.DbConnectionName
      , table.Name
      , (mySetting.IsAggregateRoot ? "AggregateRoot" : "BaseEntity")
      , colStr);

            return res;
        }

        public static string MakeIReposityCs(Table table, MySetting mySetting)
        {
            string res = string.Format(@"
using Com.Core;
using System.Collections.Generic;
using {0};

namespace {1}
{{
    public interface I{2}Repository : IRepository<{2}>
    {{
    }}
}}
", mySetting.DominNamespace + (mySetting.IsUseDir && !string.IsNullOrEmpty(mySetting.DomainDir) ? "." + mySetting.DomainDir.Replace("\\", ".") : "")
 , mySetting.IReposityNamespace + (mySetting.IsUseDir && !string.IsNullOrEmpty(mySetting.IReposityDir) ? "." + mySetting.IReposityDir.Replace("\\", ".") : "")
 , table.ClassName);

            return res;
        }

        public static string MakeReposityCs(Table table, MySetting mySetting)
        {
            string res = string.Format(@"
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using {0};
namespace {1}
{{
    public partial class {2}Repository 
    {{
    }}
}}
", mySetting.DominNamespace + (mySetting.IsUseDir && !string.IsNullOrEmpty(mySetting.DomainDir) ? "." + mySetting.DomainDir.Replace("\\", ".") : "")
 , mySetting.ReposityNamespace + (mySetting.IsUseDir && !string.IsNullOrEmpty(mySetting.ReposityDir) ? "." + mySetting.ReposityDir.Replace("\\", ".") : "")
 , table.ClassName);

            return res;
        }

        public static string MakeReposityDesignerCs(Table table, MySetting mySetting)
        {
            string res = string.Format(@"
using Com.Core;
using {0};
using {1};

namespace {2}
{{
    public partial class {3}Repository : BaseRepository<{3}>, I{3}Repository
    {{
        public {3}Repository()
            : base(""{4}"")
        {{
        }}
        public {3}Repository(string configName)
          : base(configName)
        {{
        }}
        public {3}Repository(IUnitOfWork unitOfWork)
         : base(unitOfWork)
        {{
        }}
    }}
}}
", mySetting.DominNamespace + (mySetting.IsUseDir && !string.IsNullOrEmpty(mySetting.DomainDir) ? "." + mySetting.DomainDir.Replace("\\", ".") : "")
 , mySetting.IReposityNamespace + (mySetting.IsUseDir && !string.IsNullOrEmpty(mySetting.IReposityDir) ? "." + mySetting.IReposityDir.Replace("\\", ".") : "")
 , mySetting.ReposityNamespace + (mySetting.IsUseDir && !string.IsNullOrEmpty(mySetting.ReposityDir) ? "." + mySetting.ReposityDir.Replace("\\", ".") : "")
 , table.ClassName
 , mySetting.DbConnectionName);

            return res;
        }

        public static string MakeDbConfig(List<Connection> Connections, bool isEncode = false)
        {
            var conStr = "";
            EnDecodeHelper ed = new EnDecodeHelper();
            foreach (var c in Connections)
            {
                string cs = c.ConnectionString;
                if (isEncode)
                {
                    cs = ed.Encode(cs);
                }
                conStr += string.Format(@"
  <ConnectionString>
    <Name>{0}</Name>
    <DbType>{1}</DbType>
      <!--DbType当前支持 SqlServer,Oracle,MySql,Sqlite区分大小写 -->
    <Encrypted>{2}</Encrypted>
    <ConnectionString>{3}</ConnectionString>
  </ConnectionString>
", c.Name, c.Type, isEncode, cs);
            }

            var content = string.Format(@"
<?xml version=""1.0"" standalone=""yes""?>
<DbConfiguration xmlns=""http://DbConfiguration.august.com/DbConfiguration.xsd"">
{0}
</DbConfiguration>
    ", conStr);
            return content;
        }
    }
}
