using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateMappingGenerator
{
  public  class MySetting
    {
      public bool IsReWroteCsFile { get; set; }
      public bool IsIgnoreNull { get; set; }
      public string DbConnectionName { get; set; }
      public bool IsAggregateRoot { get; set; }
      public string DominFolderPath { get; set; }
      public string IReposityFolderPath { get; set; }
      public string ReposityFolderPath { get; set; }
      public string DominNamespace { get; set; }
      public string IReposityNamespace { get; set; }
      public string ReposityNamespace { get; set; }
    }
}
