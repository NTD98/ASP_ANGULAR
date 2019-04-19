using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application.Share.Assets;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace GWebsite.AbpZeroTemplate.Application.Assets
{
    [Abp.Authorization.AbpAuthorize(GWebsitePermissions.Pages_Administration_Asset)]

    public class AssetAppService : GWebsiteAppServiceBase, IAssetAppService
    {
        private readonly IRepository<Asset, int> repository;
        private readonly IRepository<AssetCategory, int> repositoryCategory;
        public AssetAppService(IRepository<Asset, int> repository, IRepository<AssetCategory, int> repositoryCategory)
        {
            this.repository = repository;
            this.repositoryCategory = repositoryCategory;
        }
        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Asset_Create)]
        public AssetDto CreateAsset(CreateAssetInput input)
        {
            Asset asset = ObjectMapper.Map<Asset>(input);
            asset = repository.Insert(asset);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<AssetDto>(asset);
        }
        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Asset_Delete)]
        public void DeleteAsset(int id)
        {
            Asset asset = repository.Get(id);
            asset.IsDeleted = true;
            repository.Update(asset);
            CurrentUnitOfWork.SaveChanges();
        }

        public GetAssetOuput GetAssetForEdit(NullableIdDto input)
        {
            Asset asset = null;
            if(input.Id.HasValue && input.Id > 0)
            {
                asset = repository.Get(input.Id.Value);
            }
            var output = new GetAssetOuput
            {
                Asset = asset is null ?
                new AssetDto() :
                ObjectMapper.Map<AssetDto>(asset)
            };

            int parentMenuId = output.Asset.Id;
            output.Assets = repository.GetAll()
                .Where(m => !m.IsDeleted)
                .Select(c => new ComboboxItemDto(c.Id.ToString(), c.Name) { IsSelected = parentMenuId == c.Id })
                .ToList();

            return output;
        }

        public ListResultDto<AssetDto> GetAssets()
        {
            List<Asset> assets = repository.GetAllList();
            return new ListResultDto<AssetDto>(
                assets.Select(item => ObjectMapper.Map<AssetDto>(item)).ToList());
        }

        public PagedResultDto<AssetDto> GetAssets(GetAssetInput input)
        {
            IQueryable<Asset> query = repository.GetAll().WhereIf(!string.IsNullOrWhiteSpace(input.Name), item => item.Name.Contains(input.Name));
            int totalCount = query.Count();
            List<Asset> assets = query.OrderBy(input.Sorting).PageBy(input).ToList();
            return new PagedResultDto<AssetDto>(
                totalCount,
                assets.Select(item => ObjectMapper.Map<AssetDto>(item)).ToList());
        }
        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Asset_Edit)]
        public AssetDto UpdateAsset(UpdateAssetInput update)
        {
            Asset asset = repository.Get(update.Id);
            ObjectMapper.Map(update, asset);
            asset = repository.Update(asset);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<AssetDto>(asset);
        }
    }
}
