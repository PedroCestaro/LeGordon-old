using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGordon.Core.DomianValidations;

namespace LeGordon.Adm.Entities
{
    public class Role
    {
        public Int32 Id { get; }
        public String Name { get; private set; }
        public String Values { get; private set; }

        public Role(string name, string values)
        {
            Name = name;
            Values = values;
            ValidateData();
        }

        public void SetValues(string values)
        {
            Validations.ValidatesString(values, "Values cannot be empity. Please add, unless one value");
            Values = values;    
        }

        private void ValidateData()
        {
            Validations.ValidatesString(Name, "Please, add a name for the role");
            Validations.ValidatesString(Values, "Please inform the values for the role");
        }
    }
}
