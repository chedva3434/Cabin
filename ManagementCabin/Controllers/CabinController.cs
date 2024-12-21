using Clean.Core.Models;
using Clean.Core.Service;
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
        public void Post([FromBody] Cabin value)
        {
            _cabinService.AddValue(value);
        }

        // PUT api/<CabinController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Cabin value)
        {
           _cabinService.PutValue(value);
        }

        // DELETE api/<CabinController>/5
        [HttpDelete("{id}")]
        public void Delete(Cabin cabin)
        {
           _cabinService.Delete(cabin);
        }
    }
}
