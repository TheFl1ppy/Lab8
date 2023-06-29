using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Product
    {
        public Product()
        {
            CategoryToProducts = new HashSet<CategoryToProduct>();
            FeatureToProducts = new HashSet<FeatureToProduct>();
            OrderContents = new HashSet<OrderContent>();
            TagsToProducts = new HashSet<TagsToProduct>();
        }

        public int ProductId { get; set; }
        public int Tags { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Category { get; set; }

        public virtual ICollection<CategoryToProduct> CategoryToProducts { get; set; }
        public virtual ICollection<FeatureToProduct> FeatureToProducts { get; set; }
        public virtual ICollection<OrderContent> OrderContents { get; set; }
        public virtual ICollection<TagsToProduct> TagsToProducts { get; set; }
    }
}
