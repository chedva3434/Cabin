using Clean.Core.Models;
using Clean.Core.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderService.GetAll();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orderService.GetById(id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order newOrder)
        {
            _orderService.AddValue(newOrder);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Order value)
        {
            _orderService.PutValue(value);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(Order order)
        {
            _orderService.Delete(order);
        }
    }
}
