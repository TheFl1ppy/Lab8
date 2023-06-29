using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Feature
    {
        public Feature()
        {
            FeatureToCategories = new HashSet<FeatureToCategory>();
            FeatureToProducts = new HashSet<FeatureToProduct>();
        }

        public int FeatureId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FeatureToCategory> FeatureToCategories { get; set; }
        public virtual ICollection<FeatureToProduct> FeatureToProducts { get; set; }
    }
}
