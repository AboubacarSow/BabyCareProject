using AutoMapper;
using BabyCareProject.Dtos.ProductDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<CreateProdutDto, Product>();
        }
    }
}
