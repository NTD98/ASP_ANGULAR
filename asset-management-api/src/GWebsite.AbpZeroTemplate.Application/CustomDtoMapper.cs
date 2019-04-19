using AutoMapper;
using GWebsite.AbpZeroTemplate.Application.Share.AssetCategories.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Depreciations.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using GWebsite.AbpZeroTemplate.Web.Core.Departments.Dto;

namespace GWebsite.AbpZeroTemplate.Applications
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //configuration.CreateMap<Department, DepartmentDto>();
            //configuration.CreateMap<Department, DepartmentListDto>();
            //configuration.CreateMap<CreateDepartmentInput, Department>();
            //configuration.CreateMap<UpdateDepartmentInput, Department>();

            // DemoModel
            configuration.CreateMap<DemoModel, DemoModelDto>();
            configuration.CreateMap<DemoModelInput, DemoModel>();
            configuration.CreateMap<DemoModel, DemoModelInput>();

            configuration.CreateMap<Department, DepartmentDto>();
            configuration.CreateMap<CreateDepartmentInput, Department>();
            configuration.CreateMap<UpdateDepartmentInput, Department>();

            configuration.CreateMap<MenuClient, MenuClientDto>();
            configuration.CreateMap<CreateMenuClientInput, MenuClient>();
            configuration.CreateMap<UpdateMenuClientInput, MenuClient>();

            configuration.CreateMap<Depreciation, DepreciationDto>();
            configuration.CreateMap<CreateDepreciationInput, Depreciation>();
            configuration.CreateMap<UpdateDepreciationInput, Depreciation>();

            // Asset Category
            configuration.CreateMap<AssetCategory, AssetCategoryDto>();
            configuration.CreateMap<CreateAssetCategoryInput, AssetCategory>();
            configuration.CreateMap<UpdateAssetCategoryInput, AssetCategory>();

            // Asset
            configuration.CreateMap<Asset, AssetDto>();
            configuration.CreateMap<CreateAssetInput, Asset>();
            configuration.CreateMap<UpdateAssetInput, Asset>();
        }
    }
}