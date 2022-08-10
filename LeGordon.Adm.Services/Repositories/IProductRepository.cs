using LeGordon.Adm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Services.Repositories
{
    public interface IProductRepository
    {
        Task PersistsNewProduct(Product product);
    }
}
