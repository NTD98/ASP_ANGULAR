using Abp.Runtime.Validation;
using GSoft.AbpZeroTemplate.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Web.Core.Departments.Dto
{
    public class GetDepartmentInput: PagedAndSortedInputDto, IShouldNormalize
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "user.Name, user.Surname";
            }
            else if (Sorting.Contains("name"))
            {
                Sorting = Sorting.Replace("userName", "user.userName");
            }
            else if (Sorting.Contains("addedTime"))
            {
                Sorting = Sorting.Replace("addedTime", "uou.creationTime");
            }
        }
    }
}
