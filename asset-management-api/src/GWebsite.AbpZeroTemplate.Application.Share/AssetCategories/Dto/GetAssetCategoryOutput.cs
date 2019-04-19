using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace GWebsite.AbpZeroTemplate.Application.Share.AssetCategories.Dto
{
    public class GetAssetCategoryOutput
    {
        public AssetCategoryDto AssetCategory { get; set; }

        public List<ComboboxItemDto> AssetCategories { get; set; }

        public GetAssetCategoryOutput() => AssetCategories = new List<ComboboxItemDto>();
    }
}
