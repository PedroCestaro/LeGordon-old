﻿using LeGordon.Core.DomianValidations;
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
        public Decimal Price { get; private set; }
        public Int32 CategoryId { get; private set; }

        public virtual Category Category { get; private set; }
       
        public virtual ICollection<ProductImage> ProductImages { get; private set; }

        private Product() { }

        public Product(string name, string description, decimal price, int categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;

            ProductValidations.ValideProductData(name, description, price, categoryId);
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

        public void ChangePrice(decimal price)
        {
            Price = price;
        }

    }
}
