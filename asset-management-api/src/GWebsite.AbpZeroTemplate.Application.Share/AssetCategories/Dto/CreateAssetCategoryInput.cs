using System.ComponentModel.DataAnnotations;

namespace GWebsite.AbpZeroTemplate.Application.Share.AssetCategories.Dto
{
    public class CreateAssetCategoryInput
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Alias { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}
