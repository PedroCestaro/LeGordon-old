using LeGordon.Adm.Data.Contexts;
using LeGordon.Adm.Entities;
using LeGordon.Adm.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Data.Repositories
{
    internal class ProductRepository : IProductRepository, IDisposable
    {
        private readonly AdmContext _context;
        private readonly IPersistenceDB _persistence;
        private readonly IReadDB _read;

        public ProductRepository(AdmContext context, IPersistenceDB persistence,IReadDB read)
        {
            _context = context;
            _persistence = persistence;
            _read = read;
        }



        public async Task SaveNewProduct(Product newProduct)
        {
            await _persistence.SaveProductInSQL(newProduct);

            var product = await _persistence. GetProductFromSql(newProduct.Id);

            await _read.SaveProductInNoSql(product);
        }

        



        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
