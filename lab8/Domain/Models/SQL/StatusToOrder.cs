using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class StatusToOrder
    {
        public int StatusId { get; set; }
        public int OrderId { get; set; }

        public virtual Status Status { get; set; }
    }
}
