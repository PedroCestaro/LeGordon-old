using LeGordon.Adm.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Domain.Validations
{
    internal static class ProductValidations
    {
        public static void ValidatesName(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ProductDomainException("name is unvalid");
        }

        public static void ValidatesDescription(string description)
        {
            if (String.IsNullOrEmpty(description))
                throw new ProductDomainException("Description not valid");
        }

        public static void ValidatesValue(decimal value)
        {
            if (value <= 0)
                throw new ProductDomainException("Value cannot be zero or less");
        }
    }
}
