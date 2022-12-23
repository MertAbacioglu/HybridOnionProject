using AutoMapper;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //Mappings from DTO to Entities and vice-versa
            CreateMap<Product, ProductDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Language, LanguageDto>().ReverseMap();
            CreateMap<AppUserLanguage, AppUserLanguageDto>().ForMember(x => x.Id, y => y.Ignore()).ReverseMap();

            CreateMap<Product, ProductsWithCategoryDto>()
                .ForMember(dest => dest.CategoryDto, act => act.MapFrom(src => src.Category))
                .ReverseMap();
        }
    }
}