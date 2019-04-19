using Abp.Domain.Entities;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class Department : Entity<int>
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Address { get; set; }
    }
}
