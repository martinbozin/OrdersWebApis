using System.Linq;
using NUnit.Framework;

namespace OrdersApp.Data.Tests
{
    [TestFixture]
    public class DatabaseMappingTests
    {
        [Test]
        public void can_read_customers()
        {
            var context = new OrdersAppDbContext();
            var customer = context.Customer.FirstOrDefault();
            Assert.IsNotNull(customer);
        }

        [Test]
        public void can_read_orders()
        {
            var context = new OrdersAppDbContext();
            var orders = context.Orders.ToList();
            Assert.IsNotNull(orders);
        }
    }
}
