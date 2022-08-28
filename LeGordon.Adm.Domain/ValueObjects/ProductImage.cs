using LeGordon.Adm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Domain.ValueObjects
{
    public class ProductImage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
