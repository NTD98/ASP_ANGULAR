using Abp.Domain.Entities;
using System;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class Depreciation : Entity<int>
    {
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
