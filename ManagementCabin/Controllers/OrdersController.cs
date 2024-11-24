﻿using Clean.Core.Models;
using Clean.Core.Service;
using Clean.Service;
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
            _orderService.PostValu(newOrder);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DateTime d)
        {
            _orderService.PutById(id, d);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _orderService.DeleteById(id);
        }
    }
}
