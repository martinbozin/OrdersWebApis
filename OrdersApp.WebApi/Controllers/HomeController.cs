using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using log4net;
using OrdersApp.Data;
using OrdersApp.ViewModels;

namespace OrdersApp.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog Log;
        public ActionResult Index()
        {
            ViewBag.Title = "OrderApp Home Page";

            try
            {
                var orderAppDbContext = new OrdersAppDbContext();

                var customers = orderAppDbContext.Customer.ToList();

                var list = new List<CustomerViewModel>();
                foreach (var item in customers)
                {
                    var returnCustomer = new CustomerViewModel
                    {
                        CustomerId = item.CustomerId,
                        Email = item.Email,
                        Name = item.Name
                    };
                    list.Add(returnCustomer);
                }
 
                return View(list);
            }
            catch (Exception exception)
            {
                Log.Error(exception);
                throw;
            }
        }
    }
}
