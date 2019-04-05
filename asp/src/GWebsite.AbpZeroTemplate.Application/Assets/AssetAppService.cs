using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.Assets;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
namespace GWebsite.AbpZeroTemplate.Web.Core.Assets
{

    public class AssetAppService : GWebsiteAppServiceBase, IAssetAppService
    {
        private readonly IRepository<Asset> assetRepository;
        
        public AssetAppService(IRepository<Asset> assetRepository)
        {
            this.assetRepository = assetRepository;
        }

        public async Task<ListResultDto<AssetForViewDto>> GetAssetForView()
        {
            var items = await assetRepository.GetAllListAsync();
            return new ListResultDto<AssetForViewDto>(
                items.Select(item => ObjectMapper.Map<AssetForViewDto>(item)).ToList());
        }

        public PagedResultDto<AssetDto> GetAssets(AssetFilter input)
        {
            var query = assetRepository.GetAll().Where(x => x.IsDelete == false);

            // filter by Area
            if (input.Area != null)
            {
                query = query.Where(x => x.Area == input.Area);
            }

            // filter by Area Code
            if (input.Areacode != null)
            {
                query = query.Where(x => x.Areacode == input.Areacode);
            }
            //filter by Assetname
            if (input.Assetname != null)
            {
                query = query.Where(x => x.Assetname == input.Assetname);
            }
            //filter by UnitCode
            if (input.Unitcode != null)
            {
                query = query.Where(x => x.Unitcode == input.Unitcode);
            }
            //filter by Transaction
            if (input.Transaction != null)
            {
                query = query.Where(x => x.Transaction == input.Transaction);
            }
            //filter by AssetCode
            if (input.Assetcode != null)
            {
                query = query.Where(x => x.Assetcode == input.Assetcode);
            }
            //filter by SeriNumber
            if (input.Serinumber != null)
            {
                query = query.Where(x => x.Serinumber == input.Serinumber);
            }
            var totalCount = query.Count();

            // sorting
            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                query = query.OrderBy(input.Sorting);
            }

            // paging
            var items = query.PageBy(input).ToList();

            // result
            return new PagedResultDto<AssetDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<AssetDto>(item)).ToList());
        }
    }
}
