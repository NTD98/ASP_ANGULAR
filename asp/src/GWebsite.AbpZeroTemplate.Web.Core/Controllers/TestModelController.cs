using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.TestModels;
using GWebsite.AbpZeroTemplate.Application.Share.TestModels.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{

        [Route("api/[controller]/[action]")]
        public class TestModelController : GWebsiteControllerBase
        {
            private readonly ITestModelAppService testModelAppService;

            public TestModelController(ITestModelAppService testModelAppService)
            {
                this.testModelAppService = testModelAppService;
            }

            [HttpGet]
            public PagedResultDto<TestModelDto> GetTestModelsByFilter(TestModelFilter testModelFilter)
            {
                return testModelAppService.GetTestModels(testModelFilter);
            }

            [HttpGet]
            public TestModelInput GetTestModelForEdit(int id)
            {
                return testModelAppService.GetTestModelForEdit(id);
            }

            [HttpPost]
            public TestModelDto CreateOrEditTestModel([FromBody] TestModelInput input)
            {
                return testModelAppService.CreateOrEditTestModel(input);
            }

            [HttpDelete("{id}")]
            public void DeleteTestModel(int id)
            {
                testModelAppService.DeleteTestModel(id);
            }

            [HttpGet]
            public TestModelForViewDto GetTestModelForView(int id)
            {
                return testModelAppService.GetTestModelForView(id);
            }
    }
    
}
