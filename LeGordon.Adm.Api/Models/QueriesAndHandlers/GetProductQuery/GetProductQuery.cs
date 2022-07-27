using MediatR;

namespace Legordon.Adm.Api.Models 
{ 
    public class GetProductQuery: IRequest
    {
        public Guid? ProductId { get; set; }
        public string? ProductName { get; set; }
        public Int32? CategoryId{ get; set; }
    }
}
