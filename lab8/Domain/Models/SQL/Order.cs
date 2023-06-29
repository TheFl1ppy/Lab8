using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShop.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int UsersId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfPayment { get; set; }
        public int StatusId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Status Status { get; set; }
        public virtual User Users { get; set; }
        public virtual OrderContent OrderContent { get; set; }
    }
}
