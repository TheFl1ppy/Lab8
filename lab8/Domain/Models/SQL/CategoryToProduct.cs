using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class CategoryToProduct
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
