using LeGordon.Adm.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Domain.Entities
{
    public sealed class Category
    {
        public Int32 Id { get; private set; }
        public String Name { get; private set; }    
        public Boolean IsActive { get; private set; }

        private ICollection<Product> _products { get; set; }

        private Category() { }

        public Category(string name)
        {
            Name = name;
            IsActive = true;
        }

        public void Activate() => IsActive = true;
        public void Deactivate() => IsActive = false;
        

    }
}
