using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Web.ViewModels;

namespace NLayer.Web.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {

            CreateMap<ProductDto, ProductVM>().ReverseMap();
            CreateMap<ProductDto, ProductAddVM>().ReverseMap();

        }
    }
}
