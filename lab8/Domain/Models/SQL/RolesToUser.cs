using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class RolesToUser
    {
        public int RolesId { get; set; }
        public int UsersId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Role Roles { get; set; }
        public virtual User Users { get; set; }
    }
}
