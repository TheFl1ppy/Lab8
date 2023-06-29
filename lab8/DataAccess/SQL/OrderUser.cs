using System;
using System.Collections.Generic;

namespace DataAccess.SQL
{
    public partial class OrderUser
    {
        public OrderUser()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public int? TypeDelivery { get; set; }
        public string? Address { get; set; }
        public int? IdUsers { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Status { get; set; }

        public virtual User? IdUsersNavigation { get; set; }
        public virtual TypeDelivery? TypeDeliveryNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
