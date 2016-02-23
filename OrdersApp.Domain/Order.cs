using System;

namespace OrdersApp.Domain
{
    public class Order
    {
        public int OrderId { get; set; }   
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; } 
    }
}