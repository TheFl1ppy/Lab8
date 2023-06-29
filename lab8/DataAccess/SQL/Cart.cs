using System;
using System.Collections.Generic;

namespace DataAccess.SQL
{
    public partial class Cart
    {
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int? Amount { get; set; }
        public int? TotalCost { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual OrderUser IdOrderNavigation { get; set; } = null!;
        public virtual Product IdProductNavigation { get; set; } = null!;
    }
}
