using LeGordon.Adm.Api.Models;
using MediatR;

namespace LeGordon.Adm.Api.CQRS
{
    public class CreateProductCommand : IRequest
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool isActive { get { return true; } }
        public double value { get; set; }
        public int categoryId { get; set; }
        public List<Images> productImages {get;set;}
    }
}
