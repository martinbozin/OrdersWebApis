using System.Collections.Generic;

namespace OrdersApp.ViewModels
{
    public class CustomerViewModel
    {
        public List<OrderViewModel> Orders;
        public CustomerViewModel()
        {
            Orders = new List<OrderViewModel>();
        }

        public virtual int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
 
    }
}
