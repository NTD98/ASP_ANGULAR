using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Depreciations;
using GWebsite.AbpZeroTemplate.Application.Share.Depreciations.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DepreciationController : GWebsiteControllerBase
    {
        private readonly IDepreciationAppService _depreciationAppService;

        public DepreciationController(IDepreciationAppService DepreciationAppService)
        {
            _depreciationAppService = DepreciationAppService;
        }

        [HttpGet]
        public async Task<ListResultDto<DepreciationDto>> GetDepreciations()
        {
            return await _depreciationAppService.GetDepreciationsAsync();
        }

        [HttpGet]
        public async Task<PagedResultDto<DepreciationListDto>> GetDepreciationsByFilter(string name)
        {
            return await _depreciationAppService.GetDepreciationsAsync(new GetDepreciationInput() { Name = name });
        }

        [HttpGet("{id}")]
        public async Task<DepreciationDto> GetDepreciationById(int id)
        {
            return await _depreciationAppService.GetDepreciationByIdAsync(new EntityDto<int>() { Id = id });
        }

        [HttpPost]
        public async Task<DepreciationDto> CreateDepreciation([FromBody] CreateDepreciationInput input)
        {
            return await _depreciationAppService.CreateDepreciationAsync(input);
        }

        [HttpPut]
        public async Task<DepreciationDto> UpdateDepreciation([FromBody] UpdateDepreciationInput input)
        {
            return await _depreciationAppService.UpdateDepreciationAsync(input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteDepreciation(int id)
        {
            await _depreciationAppService.DeleteDepreciationAsync(new EntityDto<int>() { Id = id });
        }

        [HttpGet]
        public async Task<GetDepreciationOutput> GetDepreciationForEdit(int id)
        {
            return await _depreciationAppService.GetDepreciationForEditAsync(new NullableIdDto() { Id = id });
        }
    }
}
