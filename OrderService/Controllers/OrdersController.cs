using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> _orders = new();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_orders);
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            order.Id = _orders.Count + 1;
            order.OrderDate = DateTime.Now;
            _orders.Add(order);

            return Ok(order);
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}