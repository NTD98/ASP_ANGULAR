using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using System;
using GWebsite.AbpZeroTemplate.Web.Core.Departments.Dto;

namespace GWebsite.AbpZeroTemplate.Web.Core.Departments
{
    public interface IDepartmentAppService
    {
        Task<ListResultDto<DepartmentDto>> GetDepartmentsAsync();

        Task<PagedResultDto<DepartmentDto>> GetDepartmentsAsync(GetDepartmentInput input);

        Task<DepartmentDto> GetDepartmentByIdAsync(EntityDto<int> input);

        Task<DepartmentDto> CreateDepartmentAsync(CreateDepartmentInput input);

        Task<DepartmentDto> UpdateDepartmentAsync(UpdateDepartmentInput input);

        Task DeleteDepartmentAsync(EntityDto<int> input);
    }
}
