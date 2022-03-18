using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGordon.Core.Exceptions;

namespace LeGordon.Core.DomianValidations
{
    public static class Validations
    {
        public static void ValidatesIfDifferent(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
                throw new DomainException(message);
        }

        public static void ValidadesNull(object Object, string message)
        {
            if(Object.Equals(null))
                throw new DomainException(message);
        }

        public static void ValidatesString(string model, string message)
        {
            if(string.IsNullOrEmpty(model))
                throw new DomainException(message);
        }

        public static void ValidatesValueLowerThanZero(decimal value, string message)
        {
            if (value <= 0)
                throw new DomainException(message);
        }

       
    }
}
