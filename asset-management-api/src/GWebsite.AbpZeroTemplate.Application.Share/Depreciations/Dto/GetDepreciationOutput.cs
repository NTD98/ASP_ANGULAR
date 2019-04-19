using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace GWebsite.AbpZeroTemplate.Application.Share.Depreciations.Dto
{
    public class GetDepreciationOutput
    {
        public DepreciationDto Depreciation { get; set; }
        public List<ComboboxItemDto> Depreciations { get; set; }

        public GetDepreciationOutput()
        {
            Depreciations = new List<ComboboxItemDto>();
        }
    }
}
