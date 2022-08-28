using LeGordon.Adm.Data.Contexts;
using LeGordon.Adm.Entities;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LeGordon.Adm.Data.Repositories
{
    internal class PersistenceRepository : IPersistenceDB
    {
        private readonly AdmContext _context;

        public PersistenceRepository(AdmContext context) 
        {
            _context = context;
        }

        public async Task SaveProductInSQL(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public Task<Product> GetProductFromSql(Guid productId)
        {
            return _context.Products
                .Where(x => x.Id == productId)
                .Include(x => x.ProductImages)
                .FirstAsync();
        }
    }
}
