using AutoMapper;
using rest_api.Models;

namespace rest_api.Profiles
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
