using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Web.Core.Departments;
using GWebsite.AbpZeroTemplate.Web.Core.Departments.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DepartmentController : GWebsiteControllerBase
    {
        private readonly IDepartmentAppService _DepartmentAppService;

        public DepartmentController(IDepartmentAppService DepartmentAppService)
        {
            _DepartmentAppService = DepartmentAppService;
        }

        [HttpGet]
        public async Task<ListResultDto<DepartmentDto>> GetDepartments()
        {
            return await _DepartmentAppService.GetDepartmentsAsync();
        }

        [HttpPost]
        public async Task<DepartmentDto> CreateDepartment([FromBody] CreateDepartmentInput input)
        {
            return await _DepartmentAppService.CreateDepartmentAsync(input);
        }

        [HttpPut]
        public async Task<DepartmentDto> UpdateDepartment([FromBody] UpdateDepartmentInput input)
        {
            return await _DepartmentAppService.UpdateDepartmentAsync(input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteDepartment(int id)
        {
            await _DepartmentAppService.DeleteDepartmentAsync(new EntityDto<int>() { Id = id });
        }
    }
}
