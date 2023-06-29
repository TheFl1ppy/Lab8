using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class FeatureToProduct
    {
        public int ProductId { get; set; }
        public int FeatureId { get; set; }
        public int Values { get; set; }

        public virtual Feature Feature { get; set; }
        public virtual Product Product { get; set; }
    }
}
