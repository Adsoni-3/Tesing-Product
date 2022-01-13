using ProductAPI.Application.Features.Products.Commands.CreateProduct;
using ProductAPI.Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using ProductAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductAPI.Application.Mappings
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
