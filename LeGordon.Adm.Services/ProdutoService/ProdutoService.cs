using LeGordon.Adm.Services.Interfaces;

namespace LeGordon.Adm.Services
{
    public abstract class ProdutoService : IFacade, IProductService
    {
        private ProductFactory _productFactory { get; set; }  


        public async Task CreateProduct(ProductDto dto)
        {
           await _productFactory.CreateProduct(dto);
        }

    }
}
