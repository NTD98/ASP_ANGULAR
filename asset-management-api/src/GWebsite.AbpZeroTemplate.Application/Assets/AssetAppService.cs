using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Authorization;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.Assets;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GWebsite.AbpZeroTemplate.Web.Core.Assets
{

    public class AssetAppService : GWebsiteAppServiceBase, IAssetAppService
    {
        private readonly IRepository<Asset> assetRepository;
        
        public AssetAppService(IRepository<Asset> assetRepository)
        {
            this.assetRepository = assetRepository;
        }
        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Asset_Create)]
        public async Task<AssetDto> CreateAsset(AssetInput assetInput)
        {
            var entity = ObjectMapper.Map<Asset>(assetInput);
            entity = await assetRepository.InsertAsync(entity);
            return ObjectMapper.Map<AssetDto>(entity);
        }
        public async Task<AssetDto> UpdateAssetAsync(UpdateAssetInput input)
        {
            var entity = await assetRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, entity);
            entity = await assetRepository.UpdateAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<AssetDto>(entity);
        }

        public async Task<GetAssetOutput> GetAssetForEditAsync(NullableIdDto input)
        {
            Asset menuClient = null;
            if (input.Id.HasValue && input.Id.Value > 0)
            {
                menuClient = await assetRepository.GetAsync(input.Id.Value);
            }
            var output = new GetAssetOutput();

            output.Asset = menuClient != null
                ? ObjectMapper.Map<AssetDto>(menuClient)
                : new AssetDto();

            var parentMenuId = output.Asset.ParentId ?? 0;
            output.Assets = await assetRepository.GetAll()
                .Where(m => m.Status)
                .Select(c => new ComboboxItemDto(c.Id.ToString(), c.Assetname) { IsSelected = parentMenuId == c.Id })
                .ToListAsync();

            return output;
        }

        public async Task<ListResultDto<AssetForViewDto>> GetAssetForView()
        {
            var items = await assetRepository.GetAllListAsync();
            return new ListResultDto<AssetForViewDto>(
                items.Select(item => ObjectMapper.Map<AssetForViewDto>(item)).ToList());
        }

        public PagedResultDto<AssetDto> GetAssets(AssetFilter input)
        {
            var query = assetRepository.GetAll().Where(x => x.IsDelete == false);

            // filter by Area
            if (input.Area != null)
            {
                query = query.Where(x => x.Area.Contains(input.Area));
            }

            // filter by Area Code
            if (input.Areacode != null)
            {
                query = query.Where(x => x.Areacode.ToLower().Contains(input.Areacode.ToLower()));
            }
            //filter by Assetname
            if (input.Assetname != null)
            {
                query = query.Where(x => x.Assetname.ToLower().Contains(input.Assetname.ToLower()));
            }
            //filter by UnitCode
            if (input.Unitcode != null)
            {
                query = query.Where(x => x.Unitcode.ToLower().Contains(input.Assetname.ToLower()));
            }
            //filter by Transaction
            if (input.Transaction != null)
            {
                query = query.Where(x => x.Transaction.ToLower().Contains(input.Transaction.ToLower()));
            }
            //filter by AssetCode
            if (input.Assetcode != null)
            {
                query = query.Where(x => x.Assetcode.ToLower().Contains(input.Assetcode.ToLower()));
            }
            //filter by SeriNumber
            if (input.Serinumber != null)
            {
                query = query.Where(x => x.Serinumber.ToLower().Contains(input.Serinumber.ToLower()));
            }
            var totalCount = query.Count();

            // sorting
            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                query = query.OrderBy(input.Sorting);
            }

            // paging
            var items = query.PageBy(input).ToList();

            // result
            return new PagedResultDto<AssetDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<AssetDto>(item)).ToList());
        }
    }
}
