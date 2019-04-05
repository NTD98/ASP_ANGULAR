using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.Assets
{
    public interface IAssetAppService
    {
        //void DeleteAsset(int id);        
        PagedResultDto<AssetDto> GetAssets(AssetFilter input);
        Task<ListResultDto<AssetForViewDto>> GetAssetForView();
    }
}
