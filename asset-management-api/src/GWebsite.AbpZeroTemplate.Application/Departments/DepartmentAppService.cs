using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using GWebsite.AbpZeroTemplate.Web.Core.Departments;
using GWebsite.AbpZeroTemplate.Web.Core.Departments.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Departments
{
    [AbpAuthorize(GWebsitePermissions.Pages_Administration_Department)]

    public class DepartmentAppService : GWebsiteAppServiceBase, IDepartmentAppService
    {
        private readonly IRepository<Department, int> _departmentRepository;

        public DepartmentAppService(IRepository<Department, int> departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<ListResultDto<DepartmentDto>> GetDepartmentsAsync()
        {
            var items = await _departmentRepository.GetAllListAsync();

            return new ListResultDto<DepartmentDto>(
                items.Select(item => ObjectMapper.Map<DepartmentDto>(item)).ToList());
        }

        public async Task<PagedResultDto<DepartmentDto>> GetDepartmentsAsync(GetDepartmentInput input)
        {
            var query = _departmentRepository.GetAll()
                .WhereIf(!input.Name.IsNullOrWhiteSpace(), m => m.Name.Contains(input.Name));

            var totalCount = await query.CountAsync();
            var items = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            return new PagedResultDto<DepartmentDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<DepartmentDto>(item)).ToList());
        }

        public async Task<DepartmentDto> GetDepartmentByIdAsync(EntityDto<int> input)
        {
            var entity = await _departmentRepository.GetAsync(input.Id);
            return ObjectMapper.Map<DepartmentDto>(entity);
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Department_Create)]
        public async Task<DepartmentDto> CreateDepartmentAsync(CreateDepartmentInput input)
        {
            var entity = ObjectMapper.Map<Department>(input);
            entity = await _departmentRepository.InsertAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<DepartmentDto>(entity);
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Department_Edit)]
        public async Task<DepartmentDto> UpdateDepartmentAsync(UpdateDepartmentInput input)
        {
            var entity = await _departmentRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, entity);
            entity = await _departmentRepository.UpdateAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<DepartmentDto>(entity);
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_Department_Delete)]
        public async Task DeleteDepartmentAsync(EntityDto<int> input)
        {
            var entity = await _departmentRepository.GetAsync(input.Id);
            entity = await _departmentRepository.UpdateAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
        }


    }
}