using Clean.Core.Models;
using Clean.Core.Service;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinController : ControllerBase
    {
        private readonly ICabinService _cabinService;

        public CabinController(ICabinService cabinService)
        {
            _cabinService = cabinService;
        }

        // GET: api/<CabinController>
        [HttpGet]
        public IEnumerable<Cabin> Get()
        {
      
            return _cabinService.GetAll();
        }

        [HttpGet("{id}")]
        public Cabin Get(int id)
        {
           return _cabinService.GetById(id);
        }

        // POST api/<CabinController>
        [HttpPost]
        public void Post([FromBody] Cabin newCabin)
        {
            _cabinService.AddValue(newCabin);
        }

        // PUT api/<CabinController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string? name, double price)
        {
           _cabinService.PutValue(id, name, price);
        }

        // DELETE api/<CabinController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _cabinService.Delete(id);
        }
    }
}
