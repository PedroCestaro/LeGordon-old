using LeGordon.Adm.Entities;
using LeGordon.Adm.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Services.Interfaces
{
    public interface IProductAbstractFactory
    {
        public Product CreateProduct(ProductDto model);
    }
}
