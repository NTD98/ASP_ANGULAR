using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class TestModel : FullAuditModel
    {
        public int? Value { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime? Date { get; set; }
    }
}
