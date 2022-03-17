using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Entities
{
    public class Role
    {
        public Int32 Id { get; }
        public String Section { get; private set; }
        public String Values { get; private set; }

        public Role(string section, string values)
        {
            Section = section;
            Values = values;
        }
    }
}
