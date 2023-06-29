using System;
using System.Collections.Generic;

namespace DataAccess.SQL
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Cost { get; set; }
        public int? Discount { get; set; }
        public int? Categories { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual CategoriseProduct? CategoriesNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
