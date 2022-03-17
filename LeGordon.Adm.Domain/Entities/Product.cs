using LeGordon.Adm.Domain.Exceptions;
using LeGordon.Adm.Domain.Interfaces;
using LeGordon.Adm.Domain.Validations;
using LeGordon.Adm.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Entities
{
    public class Product : Entity, IAggregateRoot
    {
        public String Name { get; private set; }
        public String Description { get; private set; }
        public Boolean IsActive { get; private set; }
        public Decimal Value { get; private set; }
        public Int32 CategoryId { get; private set; }

        public Category Category { get; private set; }
       
        public ICollection<ProductImage> ProductImages { get; private set; }

        private Product() { }

        public Product(string name, string description, decimal value, int categoryId)
        {
            Name = name;
            Description = description;
            Value = value;
            CategoryId = categoryId;

            ValidateData();
        }

        public void ChangeName(string name)
        {
            ProductValidations.ValidatesName(name);
            Name = name;
        }

        public void ChangesDescription(string description)
        {
            ProductValidations.ValidatesDescription(description);
            Description = description;
        }

        public void ChangeValue(decimal value)
        {
            ProductValidations.ValidatesValue(value);
            Value = value;
        }

        private void ValidateData()
        {
            ProductValidations.ValidatesName(Name);
            ProductValidations.ValidatesValue(Value);
            ProductValidations.ValidatesDescription(Description);
        }


    }
}
