using Abp.Runtime.Validation;
using GSoft.AbpZeroTemplate.Dto;

namespace GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto
{
    public class GetAssetInput : PagedAndSortedInputDto, IShouldNormalize
    {
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
