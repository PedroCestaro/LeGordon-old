using LeGordon.Adm.Entities;

namespace LeGordon.Adm.Services
{
    public sealed class ProductFactory 
    {
        public Task<Product> CreateProduct(ProductDto model)
        {
            return Task.FromResult( new Product(model.Name, model.Description, model.Value, model.CategoryId));
        }
    }
}
