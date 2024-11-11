using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        static List<Order> orders = new List<Order>();
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var order=orders.Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order newOrder)
        {
            orders.Add(newOrder);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DateTime d)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == id)
                {
                    orders[i].dateOfOrder=d;
                }
            }
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for(int i = 0;i < orders.Count;i++)
            {
                if (orders[i].Id == id)
                {
                    orders.RemoveAt(i);
                }
            }
        }
    }
}
