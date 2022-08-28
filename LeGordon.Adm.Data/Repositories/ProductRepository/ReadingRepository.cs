using LeGordon.Adm.Entities;
using LeGordon.Adm.Services;
using MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Data.Repositories
{
    internal class ReadingRepository : IReadDB
    {
        public Task<ICollection<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> GetProductByFilters(ProductDto productFiltered)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task SaveProductInNoSql(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
