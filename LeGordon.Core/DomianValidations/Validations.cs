using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Core.DomianValidations
{
    internal static class Validations
    {
        public static Boolean ValidatesEquals(object object1, object object2)
        {
            return object1.Equals(object2);
        }

        public static Boolean ValidadesNull(object Object)
        {
            return Object.Equals(null);
        }

        public static void ValidatesStringNullOrEmpity(string validation)
        {
            if (String.IsNullOrEmpty(validation))
                throw new InvalidDataException("String cannot be empity");
        }
    }
}
