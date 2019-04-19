using GSoft.AbpZeroTemplate.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using System;

namespace GWebsite.AbpZeroTemplate.Application.Share.Dat_Assets.Dto
{
    /// <summary>
    /// <model cref="Asset"></model>
    /// </summary>
    public class AssetFilter : PagedAndSortedInputDto
    {
        public string Area { get; set; }
        public string Unitcode { get; set; }
        public string Areacode { get; set; }
        public string Transaction { get; set; }
        public string Assetcode { get; set; }
        public string Assetname { get; set; }
        public string Serinumber { get; set; }
    }
}
