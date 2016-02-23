using System.Collections.Generic;

namespace OrdersApp.Domain
{
    public class User
    {
        public virtual int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Order> UserOrders { get; set; }
    }
}
