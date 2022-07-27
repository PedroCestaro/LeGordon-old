using AutoMapper;
using Legordon.Adm.Api.Models;
using LeGordon.Adm.Services;

namespace Legordon.Adm.Api.Infrastructure.AutoMapper
{
    public class FromRequestToDtoMapperSetting : Profile
    {
        public FromRequestToDtoMapperSetting()
        {
            CreateMap<CreateProductCommand, ProductDto>().ReverseMap();
        }
    }
}
