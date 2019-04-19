using System.ComponentModel.DataAnnotations;

namespace GWebsite.AbpZeroTemplate.Web.Core.Departments.Dto
{
    public class CreateDepartmentInput
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Address { get; set; }
    }
}
