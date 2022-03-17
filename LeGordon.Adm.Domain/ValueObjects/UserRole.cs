using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Entities.ValueObjects
{
    public class UserRole
    {
        public Guid Id { get; }
        public Guid UserId { get; private set; }
        public Int32 RoleId { get; private set; }

        public User User { get; }
        public Role Role { get; }

        public UserRole(Guid userId, int roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    }
}
