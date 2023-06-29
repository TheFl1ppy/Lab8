using System;
using System.Collections.Generic;

namespace DataAccess.SQL
{
    public partial class Filter
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Categorise { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual CategoriseProduct? CategoriseNavigation { get; set; }
    }
}
