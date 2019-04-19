using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;

namespace GWebsite.AbpZeroTemplate.Application.Share.Assets
{
    public interface IAssetAppService
    {
        ListResultDto<AssetDto> GetAssets();
        PagedResultDto<AssetDto> GetAssets(GetAssetInput input);
        AssetDto CreateAsset(CreateAssetInput input);
        AssetDto UpdateAsset(UpdateAssetInput update);
        void DeleteAsset(int id);
        GetAssetOuput GetAssetForEdit(NullableIdDto nullableIdDto);
    }
}
