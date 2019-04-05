using GSoft.AbpZeroTemplate.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using System;

namespace GWebsite.AbpZeroTemplate.Application.Share.TestModels.Dto
{
    /// <summary>
    /// <model cref="TestModel"></model>
    /// </summary>
    public class TestModelFilter : PagedAndSortedInputDto
    {
        public int? Value { get; set; }
        public DateTime? Date { get; set; }
    }
}
