using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class TagsToProduct
    {
        public int ProductId { get; set; }
        public int TagsId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Tag Tags { get; set; }
    }
}
