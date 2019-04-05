using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.TestModels.Dto
{
    /// <summary>
    /// <model cref="TestModel"></model>
    /// </summary>
    public class TestModelForViewDto
    {
        public int? Value { get; set; }
        public string Info { get; set; }
        public DateTime? Date { get; set; }
    }
}
