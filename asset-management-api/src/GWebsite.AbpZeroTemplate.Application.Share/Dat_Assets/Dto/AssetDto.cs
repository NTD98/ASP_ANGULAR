using GWebsite.AbpZeroTemplate.Core.Models;
using System;
using Abp.Domain.Entities;
namespace GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto
{
    /// <summary>
    /// <model cref="Asset"></model>
    /// </summary>
    public class AssetDto : Entity<int>
    {
        public String Area { get; set; }
        public String Unitcode { get; set; }
        public String Areacode { get; set; }
        public String Transaction { get; set; }
        public String Assetcode { get; set; }
        public String Assetname { get; set; }
        public String Serinumber { get; set; }
        public int Originalprice { get; set; }
        public int? ParentId { get; set; }
        public bool Status { get; set; }
    }
}
