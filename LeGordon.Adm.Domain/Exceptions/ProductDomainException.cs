using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Domain.Exceptions
{
    public class ProductDomainException : Exception
    {
        public ProductDomainException() { }

        public ProductDomainException(string message) : base(message) { } 
        public ProductDomainException(string message, Exception innerException) : base(message, innerException) { } 

    }
}
