using GWebsite.AbpZeroTemplate.Core.Models;
using System;

namespace GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto
{
    /// <summary>
    /// <model cref="Asset"></model>
    /// </summary>
    public class AssetDto
    {
        public String Area { get; set; }
        public String Unitcode { get; set; }
        public String Areacode { get; set; }
        public String Transaction { get; set; }
        public String Assetcode { get; set; }
        public String Assetname { get; set; }
        public String Serinumber { get; set; }
        public int Originalprice { get; set; }
    }
}
