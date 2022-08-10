using AutoMapper;
using LeGordon.Adm.Application;

namespace LeGordon.Adm.Infrastructure.IoC.AutoMapper
{
    public class FromCommandToMessage : Profile
    {
        public FromCommandToMessage()
        {
            CreateMap<CreateProductCommand, CreateProductMessage>().ReverseMap();
        }
    }
}
