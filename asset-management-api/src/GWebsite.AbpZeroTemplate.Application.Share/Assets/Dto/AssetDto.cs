using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto
{
    public class AssetDto : Entity<int>
    {
        [Required]
        public string Name { get; set; }

        public string Alias { get; set; }

        [Range(1, int.MaxValue)]
        public int CategoryID { get; set; }

        public string Seri { get; set; }

        [Range(0, double.MaxValue)]
        public double OriginalPrice { get; set; }

        public DateTime DateCheckIn { get; set; }

        public int MonthDepreciation { get; set; }

        public double DepreciationValue { get; set; }

        public string UnitCalculation { get; set; }
        public bool IsDeleted { get; set; }
    }
}
