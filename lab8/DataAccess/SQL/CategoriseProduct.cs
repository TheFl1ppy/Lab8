using System;
using System.Collections.Generic;

namespace DataAccess.SQL
{
    public partial class CategoriseProduct
    {
        public CategoriseProduct()
        {
            Filters = new HashSet<Filter>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Filter> Filters { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
