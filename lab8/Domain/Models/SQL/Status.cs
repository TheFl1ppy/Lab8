using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
            StatusToOrders = new HashSet<StatusToOrder>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<StatusToOrder> StatusToOrders { get; set; }
    }
}
