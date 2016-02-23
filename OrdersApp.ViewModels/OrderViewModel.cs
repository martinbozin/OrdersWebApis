using System;

namespace OrdersApp.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
