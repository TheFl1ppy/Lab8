using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class FeatureToCategory
    {
        public int FeatureId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Feature Feature { get; set; }
    }
}
