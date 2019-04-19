using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.AssetCategories.Dto;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.AssetCategories
{
    public interface IAssetCategoryAppService
    {
        Task<ListResultDto<AssetCategoryDto>> GetAssetCategoriesAsync();

        Task<PagedResultDto<AssetCategoryDto>> GetAssetCategoriesAsync(GetAssetCategoryInput input);

        Task<GetAssetCategoryOutput> GetAssetCategoryForEditAsync(NullableIdDto input);

        Task<AssetCategoryDto> CreateAssetCategoryAsync(CreateAssetCategoryInput input);

        Task<AssetCategoryDto> UpdateAssetCategoryAsync(UpdateAssetCategoryInput input);

        Task DeleteAssetCategoryAsync(EntityDto<int> input);
    }
}
