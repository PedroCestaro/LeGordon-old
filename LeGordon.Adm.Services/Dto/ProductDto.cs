using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Services
{
    public class ProductDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; } 
        public decimal Value { get; set; }
        public int CategoryId { get; set; }
    }
}
