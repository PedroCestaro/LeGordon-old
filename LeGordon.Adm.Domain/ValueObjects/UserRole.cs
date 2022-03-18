using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Entities.ValueObjects
{
    public class UserRole
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Int32 RoleId { get; private set; }

        public virtual User User { get; }
        public virtual Role Role { get; }

        public UserRole(Guid userId, int roleId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            RoleId = roleId;
        }
    }
}
