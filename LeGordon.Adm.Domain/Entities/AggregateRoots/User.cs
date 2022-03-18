using LeGordon.Adm.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeGordon.Adm.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public String Name { get; private set; }   
        public String Email { get; private set; }
		public String Document { get; private set; }
		public DateTime BirthDate { get; private set; }
		public UserLogin UserLogin { get; private set; }
		public UserAddress UserAddress { get; private set; }	

		public virtual ICollection<UserRole> Roles { get; set; } 
	
		public User(string name, string email, string document, DateTime birthDate, UserLogin userLogin, UserAddress userAddress)
        {
			Name = name;
			Email = email;
			Document = document;
			BirthDate = birthDate;
			UserLogin = userLogin;
			UserAddress = userAddress;
        }


	}
}
