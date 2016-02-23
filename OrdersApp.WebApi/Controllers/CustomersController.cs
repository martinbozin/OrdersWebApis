using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using log4net;
using OrdersApp.Data;
using OrdersApp.Domain;
using OrdersApp.ViewModels;


namespace OrdersApp.WebApi.Controllers
{
    [Authorize]
    public class CustomersController : ApiController
    {
        private static readonly ILog Log;

        // GET  V1/Customers
        public IQueryable<CustomerViewModel> GetCustomers()
        {
            try
            {
                var orderAppDbContext = new OrdersAppDbContext();

                var customers = from b in orderAppDbContext.Customer
                            select new CustomerViewModel()
                            {
                                CustomerId = b.CustomerId,
                                Email = b.Email,
                                Name = b.Name
                            };

                return customers;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return null;
            }
        }

        // GET V1/Customers/{id}
        public CustomerViewModel Get(int id)
        {
            try
            {
                var orderAppDbContext = new OrdersAppDbContext();

                var customer = orderAppDbContext.Customer.FirstOrDefault(x => x.CustomerId == id);
                if (customer != null)
                {
                    var returnCustomer = new CustomerViewModel
                    {
                        CustomerId = customer.CustomerId,
                        Email = customer.Email,
                        Name = customer.Name
                    };
                    if (customer.CustomerOrders.Any())
                    {
                        var listUserOrders = new List<OrderViewModel>();
                        foreach (var item in customer.CustomerOrders)
                        {
                            var order = new OrderViewModel
                            {
                                OrderId = item.OrderId,
                                Price = item.Price,
                                CreatedDate = item.CreatedDate
                            };
                            listUserOrders.Add(order);
                        }
                        returnCustomer.Orders = listUserOrders;
                    }
                    return returnCustomer;
                }
                return null;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return null;
            }
        }

        // POST V1/Customers/{id} 
        public Order Post(int id, OrderViewModel model)
        {
            try
            {
                var orderAppDbContext = new OrdersAppDbContext();

                var customer = orderAppDbContext.Customer.FirstOrDefault(x => x.CustomerId == id);
                if (customer != null)
                {
                    var order = new Order {Price = model.Price, CreatedDate = DateTime.Now, Customer = customer};
                    return order;
                }

                return null;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return null;
            }
        }

        // POST V1/Customers/
        [HttpPost]
        public Customer Post(CustomerViewModel model)
        {
            try
            {
                var orderAppDbContext = new OrdersAppDbContext();

                var customer = new Customer {Email = model.Email, Name = model.Name};
                orderAppDbContext.Customer.Add(customer);
                orderAppDbContext.SaveChanges();

                return customer;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return null;
            }
        }

    }
}
