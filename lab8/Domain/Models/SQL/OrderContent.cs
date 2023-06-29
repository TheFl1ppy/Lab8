using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class OrderContent
    {
        public OrderContent()
        {
            Carts = new HashSet<Cart>();
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
