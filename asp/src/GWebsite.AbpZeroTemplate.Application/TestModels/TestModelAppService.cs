using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.TestModels;
using GWebsite.AbpZeroTemplate.Application.Share.TestModels.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace GWebsite.AbpZeroTemplate.Web.Core.TestModels
{
    public class TestModelAppService : GWebsiteAppServiceBase, ITestModelAppService
    {
        private readonly IRepository<TestModel> testModelRepository;

        public TestModelAppService(IRepository<TestModel> testModelRepository)
        {
            this.testModelRepository = testModelRepository;
        }

        public TestModelDto CreateOrEditTestModel(TestModelInput testModelInput)
        {
            TestModel testModelEntity = null;
            if (testModelInput.Id == 0)
            {
                // Insert
                testModelEntity = ObjectMapper.Map<TestModel>(testModelInput);
                SetAuditInsert(testModelEntity);
                testModelRepository.Insert(testModelEntity);
                CurrentUnitOfWork.SaveChanges();
            }
            else
            {
                // Update
                testModelEntity = testModelRepository.GetAll().Where(x => x.IsDelete == false).SingleOrDefault(x => x.Id == testModelInput.Id);
                if (testModelEntity == null)
                {
                    return null;
                }
                ObjectMapper.Map(testModelInput, testModelEntity);
                SetAuditEdit(testModelEntity);
                testModelRepository.Update(testModelEntity);
                CurrentUnitOfWork.SaveChanges();
            }

            return ObjectMapper.Map<TestModelDto>(testModelEntity);
        }

        public void DeleteTestModel(int id)
        {
            var testModelEntity = testModelRepository.Get(id);
            if (testModelEntity != null)
            {
                testModelEntity.IsDelete = true;
                testModelRepository.Update(testModelEntity);
                CurrentUnitOfWork.SaveChanges();
            }
        }

        public TestModelInput GetTestModelForEdit(int id)
        {
            var testModelEntity = testModelRepository.GetAll().Where(x => x.IsDelete == false).SingleOrDefault(x => x.Id == id);
            if (testModelEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<TestModelInput>(testModelEntity);
        }
        public TestModelForViewDto GetTestModelForView(int id)
        {
            var testModelEntity = testModelRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (testModelEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<TestModelForViewDto>(testModelEntity);
        }
        public PagedResultDto<TestModelDto> GetTestModels(TestModelFilter input)
        {
            var query = testModelRepository.GetAll().Where(x => x.IsDelete == false);

            // filter by value
            if (input.Value != null)
            {
                query = query.Where(x => x.Value == input.Value);
            }

            // filter by Date
            if (input.Date != null)
            {
                query = query.Where(x => x.Date == input.Date);
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
            return new PagedResultDto<TestModelDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<TestModelDto>(item)).ToList());
        }
    }
}
