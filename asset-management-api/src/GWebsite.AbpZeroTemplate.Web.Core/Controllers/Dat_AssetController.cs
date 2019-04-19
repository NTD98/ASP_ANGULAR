using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Dat_Assets;
using GWebsite.AbpZeroTemplate.Application.Share.Dat_Assets.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class Dat_AssetController : GWebsiteControllerBase
    {
        private readonly IAssetAppService assetAppService;

        public Dat_AssetController(IAssetAppService assetAppService)
        {
            this.assetAppService = assetAppService;
        }
        [HttpGet]
        public Task<ListResultDto<AssetForViewDto>> GetAssets()
        {
            return assetAppService.GetAssetForView();
        }
        [HttpGet]
        public PagedResultDto<AssetDto> GetAssetsByFilter(AssetFilter assetFilter)
        {
            return assetAppService.GetAssets(assetFilter);
        }
        [HttpPost]
        public async Task<AssetDto> CreateAsset([FromBody] AssetInput input)
        {
            return await assetAppService.CreateAsset(input);
        }
    }
}
