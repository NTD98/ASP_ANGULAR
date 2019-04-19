
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application.Share.Depreciations;
using GWebsite.AbpZeroTemplate.Application.Share.Depreciations.Dto;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Depreciations
{
    [AbpAuthorize(GWebsitePermissions.Pages_Administration_Depreciation)]
    public class DepreciationAppService : GWebsiteAppServiceBase, IDepreciationAppService
    {
        private readonly IRepository<Depreciation, int> _depreciationRepository;

        public DepreciationAppService(IRepository<Depreciation, int> depreciationRepository)
        {
            _depreciationRepository = depreciationRepository;
        }

        public async Task<ListResultDto<DepreciationDto>> GetDepreciationsAsync()
        {

            System.Collections.Generic.List<Depreciation> items = await _depreciationRepository.GetAllListAsync();

            return new ListResultDto<DepreciationDto>(
                items.Select(item => ObjectMapper.Map<DepreciationDto>(item)).ToList());

        }

        public async Task<PagedResultDto<DepreciationListDto>> GetDepreciationsAsync(GetDepreciationInput input)
        {
            IQueryable<Depreciation> query = _depreciationRepository.GetAll()
                .WhereIf(!input.Name.IsNullOrWhiteSpace(), m => m.Name.Contains(input.Name));

            int totalCount = await query.CountAsync();
            System.Collections.Generic.List<Depreciation> items = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            return new PagedResultDto<DepreciationListDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<DepreciationListDto>(item)).ToList());
        }

        public async Task<DepreciationDto> GetDepreciationByIdAsync(EntityDto<int> input)
        {
            var entity = await _depreciationRepository.GetAsync(input.Id);
            return ObjectMapper.Map<DepreciationDto>(entity);
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Depreciation_Create)]
        public async Task<DepreciationDto> CreateDepreciationAsync(CreateDepreciationInput input)
        {
            Depreciation entity = ObjectMapper.Map<Depreciation>(input);
            entity = await _depreciationRepository.InsertAsync(entity);
            return ObjectMapper.Map<DepreciationDto>(entity);
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Depreciation_Edit)]
        public async Task<DepreciationDto> UpdateDepreciationAsync(UpdateDepreciationInput input)
        {
            Depreciation entity = await _depreciationRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, entity);
            entity = await _depreciationRepository.UpdateAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<DepreciationDto>(entity);
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Depreciation_Delete)]
        public async Task DeleteDepreciationAsync(EntityDto<int> input)
        {
            Depreciation entity = await _depreciationRepository.GetAsync(input.Id);
            _ = await _depreciationRepository.UpdateAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
        }

        public async Task<GetDepreciationOutput> GetDepreciationForEditAsync(NullableIdDto input)
        {
            Depreciation depreciation = null;
            if (input.Id.HasValue && input.Id.Value > 0)
            {
                depreciation = await _depreciationRepository.GetAsync(input.Id.Value);
            }
            GetDepreciationOutput output = new GetDepreciationOutput
            {
                Depreciation = depreciation != null
                ? ObjectMapper.Map<DepreciationDto>(depreciation)
                : new DepreciationDto()
            };

            int parentMenuId = output.Depreciation.Id;
            output.Depreciations = await _depreciationRepository.GetAll()
                .Select(c => new ComboboxItemDto(c.Id.ToString(), c.Name) { IsSelected = parentMenuId == c.Id })
                .ToListAsync();

            return output;
        }
    }
}
