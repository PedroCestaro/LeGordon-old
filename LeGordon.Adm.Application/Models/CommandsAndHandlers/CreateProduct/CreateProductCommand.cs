using MediatR;

namespace LeGordon.Adm.Application
{
    public class CreateProductCommand : IRequest<Unit>
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public double Value { get; set; }
        public List<Images> ProductImages { get; set; }
    }
}
