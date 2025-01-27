using AutoMapper;
using Clean.Core.Models;
using Clean.Core.Service;
using ManagementCabin.Core.DTOs;
using ManagementCabin.Models;
using ManagementCabin.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }



        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _orderService.GetAllAsync();
            var listDto = _mapper.Map<IEnumerable<OrderDto>>(list);
            return Ok(listDto);
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var cabin = _orderService.GetByIdAsync(id);
            var cabinDto = _mapper.Map<OrderDto>(cabin);
            return Ok(cabinDto);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] OrderPostModel newOrder)
        {
            var OrderToAdd = new Order { dateOfOrder=newOrder.dateOfOrder, CabinId=newOrder.CabinId };
            _orderService.AddValueAsync(OrderToAdd);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Order value)
        {
            _orderService.PutValueAsync(value);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(Order order)
        {
            _orderService.DeleteAsync(order);
        }
    }
}
