using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Web.Core.Departments.Dto
{
    public class UpdateDepartmentInput
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Address { get; set; }
    }
}
