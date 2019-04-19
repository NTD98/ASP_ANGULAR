using Abp.Runtime.Validation;
using GSoft.AbpZeroTemplate.Dto;

namespace GWebsite.AbpZeroTemplate.Application.Share.Depreciations.Dto
{
    public class GetDepreciationInput : PagedAndSortedInputDto, IShouldNormalize
    {
        //[Range(1, int.MaxValue)]
        //public int Id { get; set; }

        public string Name { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Name";
            }
        }
    }
}
