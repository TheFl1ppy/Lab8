using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryToProducts = new HashSet<CategoryToProduct>();
            FeatureToCategories = new HashSet<FeatureToCategory>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Feature { get; set; }

        public virtual ICollection<CategoryToProduct> CategoryToProducts { get; set; }
        public virtual ICollection<FeatureToCategory> FeatureToCategories { get; set; }
    }
}
