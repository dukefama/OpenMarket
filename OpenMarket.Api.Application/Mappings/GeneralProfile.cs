using AutoMapper;
using OpenMarket.Api.Application.Features.Products.Commands.CreateProduct;
using OpenMarket.Api.Application.Features.Products.Queries.GetAllProducts;
using OpenMarket.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenMarket.Api.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
