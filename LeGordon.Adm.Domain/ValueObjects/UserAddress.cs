using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Entities.ValueObjects
{
    public class UserAddress
    {

		public String Address { get; private set; }
		public String Number { get; private set; }
		public String Reference { get; private set; }
		public Int32 ZipCode { get; private set; }
		public String City {get; private set;}
		
		public UserAddress(string address, string number, string reference, int zipCode, string city)
        {
			Address = address;
			Number = number;
			Reference = reference;
			ZipCode = zipCode;
			City = city;		
        }
    }
}
