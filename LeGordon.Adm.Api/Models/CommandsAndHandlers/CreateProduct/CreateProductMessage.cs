using LeGordon.BuildingBlocks.EventBus;

namespace Legordon.Adm.Api.Models
{
    public record CreateProductMessage: MessageBase
    {
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public Int32 CategoryId { get; set; }
        public Double Value { get; set; }
        public List<Images> ProductImages { get; set; }

        public CreateProductMessage(string productName, string productDescription, int categoryId, double value, List<Images> productImages)
        {
            ProductName = productName;
            ProductDescription = productDescription;
            CategoryId = categoryId;
            Value = value;
            ProductImages = productImages;
        }
    }
}
