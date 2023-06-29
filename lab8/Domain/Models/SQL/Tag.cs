using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Tag
    {
        public Tag()
        {
            TagsToProducts = new HashSet<TagsToProduct>();
        }

        public int TagsId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TagsToProduct> TagsToProducts { get; set; }
    }
}
