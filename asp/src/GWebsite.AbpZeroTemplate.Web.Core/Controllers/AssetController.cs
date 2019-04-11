using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Assets;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
