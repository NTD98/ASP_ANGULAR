using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
   public class Asset : FullAuditModel
    {
      public String  Area { get; set; }
      public String  Unitcode { get; set; }
      public String  Areacode { get; set; }
      public String  Transaction { get; set; }
      public String  Assetcode { get; set; }
      public String  Assetname { get; set; }
      public String  Serinumber { get; set; }
      public int     Originalprice { get; set; }
      public bool Status { get; set; }
    }
}
