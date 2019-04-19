using System;
using System.ComponentModel.DataAnnotations;

namespace GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto
{
    public class UpdateAssetInput
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Alias { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int CategoryID { get; set; }

        public string Seri { get; set; }

        [Range(0, double.MaxValue)]
        public double OriginalPrice { get; set; }

        public DateTime DateCheckIn { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string UnitCalculation { get; set; }
        public bool IsDeleted { get; set; }
    }
}
