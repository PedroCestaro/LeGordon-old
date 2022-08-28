using LeGordon.Adm.Entities;
using LeGordon.Adm.Services.Interfaces;
using LeGordon.Adm.Services.Repositories;

namespace LeGordon.Adm.Services
{
    public abstract class ProductService : IFacade, IProductService
    {
        private ProductFactory _productFactory { get; set; }

        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _productFactory = new ProductFactory();
            _repository = repository;
        }

        public async Task CreateProduct(ProductDto dto)
        {
            try
            {
                var newProduct = await _productFactory.CreateProduct(dto);
                await _repository.SaveNewProduct(newProduct);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }

    }
}
