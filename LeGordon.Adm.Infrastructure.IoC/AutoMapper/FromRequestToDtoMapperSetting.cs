using AutoMapper;
using LeGordon.Adm.Application;
using LeGordon.Adm.Services;

namespace LeGordon.Adm.Infrastructure.IoC.AutoMapper
{
    public class FromRequestToDtoMapperSetting : Profile
    {
        public FromRequestToDtoMapperSetting()
        {
            CreateMap<CreateProductCommand, ProductDto>().ReverseMap();
        }
    }
}
