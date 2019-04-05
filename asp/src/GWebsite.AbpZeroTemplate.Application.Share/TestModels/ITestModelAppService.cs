using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.TestModels.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.TestModels
{
    public interface ITestModelAppService
    {
        TestModelDto CreateOrEditTestModel(TestModelInput TestModelInput);
        TestModelInput GetTestModelForEdit(int id);
        void DeleteTestModel(int id);
        PagedResultDto<TestModelDto> GetTestModels(TestModelFilter input);
        TestModelForViewDto GetTestModelForView(int id);
    }
}
