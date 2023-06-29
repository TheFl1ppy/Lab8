using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Cart
    {
        public int UsersId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public virtual OrderContent Order { get; set; }
        public virtual User Users { get; set; }
    }
}
