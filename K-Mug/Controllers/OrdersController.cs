using K_Mug.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace K_Mug.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(this.CreateOrders().ToList());
        }

        private IList<Order> CreateOrders()
        {
            List<Order> OrderList = new List<Order> 
            {
                new Order {OrderID = 1001, CustomerName = "John", City = "India", Amount = 100 },
                new Order {OrderID = 1002, CustomerName = "Scott", City = "USA", Amount = 230},
                new Order {OrderID = 1003,CustomerName = "Micheal", City = "UK", Amount = 400 },
                new Order {OrderID = 1004,CustomerName = "Chelsea", City = "China", Amount = 1090},
                new Order {OrderID = 1005,CustomerName = "Chriss", City = "USA", Amount = 211}
            };

            return OrderList;
        }
    }
}
