using LeGordon.Adm.Services.Dto;
using LeGordon.Adm.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGordon.Adm.Entities;

namespace LeGordon.Adm.Services
{
    public sealed class ProductFactory 
    {
        public  Task<Product> CreateProduct(ProductDto model)
        {
            return Task.FromResult( new Product(model.Name, model.Description, model.Value, model.CategoryId));
        }
    }
}
