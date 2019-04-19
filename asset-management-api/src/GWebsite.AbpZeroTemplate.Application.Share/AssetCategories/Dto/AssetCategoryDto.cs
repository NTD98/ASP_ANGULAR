using Abp.Domain.Entities;

namespace GWebsite.AbpZeroTemplate.Application.Share.AssetCategories.Dto
{
    public class AssetCategoryDto : Entity<int>
    {
        public string Name { get; set; }
        public string Alias { get; set; }
    }
}