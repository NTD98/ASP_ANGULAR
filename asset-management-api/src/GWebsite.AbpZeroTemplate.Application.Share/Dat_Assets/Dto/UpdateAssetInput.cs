using System;
using System.ComponentModel.DataAnnotations;

namespace GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto
{
    public class UpdateAssetInput
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
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
