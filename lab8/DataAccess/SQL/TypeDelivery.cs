using System;
using System.Collections.Generic;

namespace DataAccess.SQL
{
    public partial class TypeDelivery
    {
        public TypeDelivery()
        {
            OrderUsers = new HashSet<OrderUser>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Cost { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<OrderUser> OrderUsers { get; set; }
    }
}
