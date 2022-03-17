using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Entities.ValueObjects
{
    public class UserLogin
    {
        public String UserName { get; private set; }
        public Byte[] Password { get; private set; }

        public UserLogin(string Username, string password)
        {
            UserName = Username;
            Password = Convert.FromBase64String(password);
        }
    }
}
