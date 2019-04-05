using AutoMapper;
using GWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.TestModels.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Applications
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<MenuClient, MenuClientDto>();
            configuration.CreateMap<MenuClient, MenuClientListDto>();
            configuration.CreateMap<CreateMenuClientInput, MenuClient>();
            configuration.CreateMap<UpdateMenuClientInput, MenuClient>();

            // DemoModel
            configuration.CreateMap<DemoModel, DemoModelDto>();
            configuration.CreateMap<DemoModelInput, DemoModel>();
            configuration.CreateMap<DemoModel, DemoModelInput>();
            //TestModel
            configuration.CreateMap<TestModel, TestModelDto>();
            configuration.CreateMap<TestModelInput, TestModel>();
            configuration.CreateMap<TestModel, TestModelInput>();
            configuration.CreateMap<TestModel, TestModelForViewDto>();
            //Asset
            configuration.CreateMap<Asset, AssetDto>();
            configuration.CreateMap<AssetDto, Asset>();
            configuration.CreateMap<Asset, AssetForViewDto>();
            configuration.CreateMap<AssetForViewDto, Asset>();
        }
    }
}