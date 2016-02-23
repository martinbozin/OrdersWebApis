using System;

namespace OrdersApp.Domain
{
    public class Order
    {
        public int OrderId { get; set; }   
        public string Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public User UserID { get; set; } 
    }
}