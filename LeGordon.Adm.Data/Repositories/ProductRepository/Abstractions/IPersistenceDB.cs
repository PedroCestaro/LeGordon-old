using LeGordon.Adm.Entities;
using LeGordon.Adm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Data.Repositories
{
    internal interface IPersistenceDB
    {
        Task SaveProductInSQL(Product newProduct);
        Task<Product>GetProductFromSql(Guid productId);
    }
}
