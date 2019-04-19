using Abp.Domain.Entities;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public partial class AssetCategory : Entity<int>, ISoftDelete
    {
        public string Name { get; set; }

        public string Alias { get; set; }

        public bool IsDeleted { get; set; }
    }
}
