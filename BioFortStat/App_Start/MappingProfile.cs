using AutoMapper;
using BioFortStat.Dto;
using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<RegisterViewModel, RegisterDto>();
            Mapper.CreateMap<RegisterDto, RegisterViewModel>();
            Mapper.CreateMap<UserInformation, UserInfoDto>();
            Mapper.CreateMap<UserInfoDto, UserInformation>();
            Mapper.CreateMap<Product, ProductDto>();
            Mapper.CreateMap<ProductDto, Product>();
            Mapper.CreateMap<Market, MarketDto>();
            Mapper.CreateMap<MarketDto, Market>();
            Mapper.CreateMap<Category, CategoryDto>();
            Mapper.CreateMap<CategoryDto, Category>();
            Mapper.CreateMap<BuyerAndSellerDto, BuyerAndSeller>();
            Mapper.CreateMap<BuyerAndSeller, BuyerAndSellerDto>();
            Mapper.CreateMap<PriceDto, Price>();
            Mapper.CreateMap<Price, PriceDto>();
            Mapper.CreateMap<ProductCategortDto, ProductCategory>();
            Mapper.CreateMap<ProductCategory, ProductCategortDto>();
            Mapper.CreateMap<DistributionRecordsDto, DistributionRecords>();
            Mapper.CreateMap<DistributionRecords, DistributionRecordsDto>();
            Mapper.CreateMap<VendorDto, VendorUser>();
            Mapper.CreateMap<VendorUser, VendorDto>();

        }
    }
}