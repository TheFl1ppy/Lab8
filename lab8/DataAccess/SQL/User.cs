using System;
using System.Collections.Generic;

namespace DataAccess.SQL
{
    public partial class User
    {
        public User()
        {
            OrderUsers = new HashSet<OrderUser>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Card { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<OrderUser> OrderUsers { get; set; }
    }
}
