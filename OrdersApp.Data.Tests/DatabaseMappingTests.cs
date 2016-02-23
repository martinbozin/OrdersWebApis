using System.Linq;
using NUnit.Framework;

namespace OrdersApp.Data.Tests
{
    [TestFixture]
    public class DatabaseMappingTests
    {
        [Test]
        public void can_read_users()
        {
            var context = new OrdersAppDbContext();
            var user = context.User.FirstOrDefault();
            Assert.IsNotNull(user);
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
