using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Role
    {
        public Role()
        {
            RolesToUsers = new HashSet<RolesToUser>();
        }

        public int RolesId { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<RolesToUser> RolesToUsers { get; set; }
    }
}
