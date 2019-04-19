using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.AssetCategories;
using GWebsite.AbpZeroTemplate.Application.Share.AssetCategories.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AssetCategoryController : GWebsiteControllerBase
    {
        private readonly IAssetCategoryAppService assetCategoryAppService;

        public AssetCategoryController(IAssetCategoryAppService assetCategoryAppService)
        {
            this.assetCategoryAppService = assetCategoryAppService;
        }

        [HttpGet]
        public async Task<ListResultDto<AssetCategoryDto>> GetAssetCategories()
        {
            return await assetCategoryAppService.GetAssetCategoriesAsync();
        }

        [HttpGet]
        public async Task<PagedResultDto<AssetCategoryDto>> GetAssetCategoriesByFilterAsync(string name)
        {
            return await assetCategoryAppService.GetAssetCategoriesAsync(new GetAssetCategoryInput { Name = name });
        }

        [HttpPost]
        public async Task<AssetCategoryDto> CreateAssetCategory([FromBody] CreateAssetCategoryInput input)
        {
            return await assetCategoryAppService.CreateAssetCategoryAsync(input);
        }

        [HttpPut]
        public async Task<AssetCategoryDto> UpdateAssetCategory([FromBody] UpdateAssetCategoryInput input)
        {
            return await assetCategoryAppService.UpdateAssetCategoryAsync(input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAssetCategory(int id)
        {
            await assetCategoryAppService.DeleteAssetCategoryAsync(new EntityDto<int> { Id = id });
        }

        [HttpGet]
        public async Task<GetAssetCategoryOutput> GetAssetCategoryForEdit(int id)
        {
            return await assetCategoryAppService.GetAssetCategoryForEditAsync(new NullableIdDto { Id = id });
        }
    }
}
