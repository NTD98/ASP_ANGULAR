using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application.Share.AssetCategories;
using GWebsite.AbpZeroTemplate.Application.Share.AssetCategories.Dto;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;


namespace GWebsite.AbpZeroTemplate.Application.AssetCategories

{
    [AbpAuthorize(GWebsitePermissions.Pages_Administration_AssetCategory)]
    public class AssetCategoryAppService : GWebsiteAppServiceBase, IAssetCategoryAppService
    {
        private readonly IRepository<AssetCategory, int> repository;

        public AssetCategoryAppService(IRepository<AssetCategory, int> repository)
        {
            this.repository = repository;
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_AssetCategory_Create)]
        public async Task<AssetCategoryDto> CreateAssetCategoryAsync(CreateAssetCategoryInput input)
        {
            AssetCategory entity = ObjectMapper.Map<AssetCategory>(input);
            AssetCategory result = await repository.InsertAsync(entity);

            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<AssetCategoryDto>(result);
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_AssetCategory_Delete)]
        public async Task DeleteAssetCategoryAsync(EntityDto<int> input)
        {
            AssetCategory assetCategory = await repository.GetAsync(input.Id);
            assetCategory.IsDeleted = true;
            await repository.UpdateAsync(assetCategory);
            await CurrentUnitOfWork.SaveChangesAsync();
        }

        public async Task<ListResultDto<AssetCategoryDto>> GetAssetCategoriesAsync()
        {
            List<AssetCategory> assetCategories = await repository.GetAllListAsync();
            return new ListResultDto<AssetCategoryDto>(
                assetCategories.Select(item => ObjectMapper.Map<AssetCategoryDto>(item)).ToList());
        }

        public async Task<PagedResultDto<AssetCategoryDto>> GetAssetCategoriesAsync(GetAssetCategoryInput input)
        {
            IQueryable<AssetCategory> query = repository.GetAll()
                .WhereIf(!input.Name.IsNullOrWhiteSpace(), m => m.Name.Contains(input.Name));
            int totalCount = await query.CountAsync();

            List<AssetCategory> items = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            return new PagedResultDto<AssetCategoryDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<AssetCategoryDto>(item)).ToList());
        }

        public async Task<GetAssetCategoryOutput> GetAssetCategoryForEditAsync(NullableIdDto input)
        {
            AssetCategory assetCategory = null;
            GetAssetCategoryOutput output = new GetAssetCategoryOutput
            {
                AssetCategory = assetCategory is null
                    ? new AssetCategoryDto()
                    : ObjectMapper.Map<AssetCategoryDto>(assetCategory)
            };
            output.AssetCategories = await repository.GetAll()
                .Where(item => !item.IsDeleted)
                .Select(item => new ComboboxItemDto(item.Id.ToString(), item.Name) { IsSelected = item.Id == input.Id })
                .ToListAsync();
            return output;
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_AssetCategory_Edit)]
        public async Task<AssetCategoryDto> UpdateAssetCategoryAsync(UpdateAssetCategoryInput input)
        {
            AssetCategory entity = await repository.GetAsync(input.Id ?? 1);
            ObjectMapper.Map(input, entity);
            entity = await repository.UpdateAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<AssetCategoryDto>(entity);
        }
    }
}
