using System.Collections.Generic;

namespace OrdersApp.Domain
{
    public class Customer
    {
        public virtual int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Order> CustomerOrders { get; set; }
    }
}
