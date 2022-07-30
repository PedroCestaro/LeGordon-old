using MediatR;

namespace LeGordon.Adm.Application
{
    public class GetProductQuery : IRequest
    {
        public Guid? ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? CategoryId { get; set; }
    }
}
