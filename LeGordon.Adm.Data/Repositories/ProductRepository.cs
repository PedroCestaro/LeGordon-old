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

        public ProductRepository(AdmContext context)
        {
            _context = context;
        }



        public async Task PersistsNewProduct(Product product)
        {
            await SaveProductInSQL(product);
            
        }

        private async Task SaveProductInSQL(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
