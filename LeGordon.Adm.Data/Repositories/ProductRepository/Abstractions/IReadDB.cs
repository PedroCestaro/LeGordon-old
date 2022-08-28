using LeGordon.Adm.Entities;
using LeGordon.Adm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Data.Repositories
{
    internal interface IReadDB
    {
        Task<Product> GetProductById(Guid Id);
        Task<ICollection<Product>> GetAllProducts();
        Task<ICollection<Product>> GetProductByFilters(ProductDto productFiltered);
        Task SaveProductInNoSql(Product product);  
    }
}
