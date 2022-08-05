using AutoMapper;
using Legordon.Adm.Api.Models;

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
