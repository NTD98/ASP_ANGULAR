using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Assets;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using Microsoft.AspNetCore.Mvc;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AssetController : GWebsiteControllerBase
    {
        private readonly IAssetAppService assetAppService;

        public AssetController(IAssetAppService assetAppService)
        {
            this.assetAppService = assetAppService;
        }

        [HttpGet]
        public ListResultDto<AssetDto> GetAssets()
        {
            return assetAppService.GetAssets();
        }

        [HttpGet]
        public PagedResultDto<AssetDto> GetAssetsByFilter(string name, string sorting, int skipCount = 0, int maxResultCount = 1)
        {
            return assetAppService.GetAssets(new GetAssetInput { Name = name, Sorting = sorting, SkipCount = skipCount, MaxResultCount = maxResultCount });
        }

        [HttpGet]
        public GetAssetOuput GetAssetForEdit(int id)
        {
            return assetAppService.GetAssetForEdit(new NullableIdDto() { Id = id });
        }


        [HttpPost]
        public AssetDto CreateAsset([FromBody] CreateAssetInput input)
        {
            return assetAppService.CreateAsset(input);
        }

        [HttpPut]
        public AssetDto UpdateAsset([FromBody] UpdateAssetInput input)
        {
            return assetAppService.UpdateAsset(input);
        }

        [HttpDelete]
        public void DeleteAsset(int id)
        {
            assetAppService.DeleteAsset(id);
        }
    }
}
