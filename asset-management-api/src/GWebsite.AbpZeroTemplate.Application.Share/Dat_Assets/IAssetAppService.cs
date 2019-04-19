using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Dat_Assets.Dto;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.Dat_Assets
{
    public interface IAssetAppService
    {
        //void DeleteAsset(int id);        
        PagedResultDto<AssetDto> GetAssets(AssetFilter input);
        Task<ListResultDto<AssetForViewDto>> GetAssetForView();
        Task<AssetDto> CreateAsset(AssetInput assetInput);
    }
}
