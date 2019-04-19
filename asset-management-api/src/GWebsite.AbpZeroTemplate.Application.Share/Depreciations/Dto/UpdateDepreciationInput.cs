using System;
using System.ComponentModel.DataAnnotations;

namespace GWebsite.AbpZeroTemplate.Application.Share.Depreciations.Dto
{
    public class UpdateDepreciationInput
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AssetId { get; set; }
        public int Quantity { get; set; }
        public string DepartmentId { get; set; }
        public string CalculationMethod { get; set; }
        public DateTime DateOfStartCalculateDepreciation { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double OriginalPrice { get; set; }
        public double DepreciationValue { get; set; }
        public double MonthlyDepreciationRate { get; set; }
        public double AnnualDepreciationRate { get; set; }
    }
}
