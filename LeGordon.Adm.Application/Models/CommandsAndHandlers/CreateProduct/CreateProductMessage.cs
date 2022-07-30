using LeGordon.BuildingBlocks.EventBus;

namespace LeGordon.Adm.Application
{
    public record CreateProductMessage : MessageBase
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public double Value { get; set; }
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
