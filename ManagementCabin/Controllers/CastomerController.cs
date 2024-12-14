using Clean.Core.Models;
using Clean.Core.Service;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastomerController : ControllerBase
    {
        private readonly ICastomerService _castomerService;

        public CastomerController(ICastomerService castomerService)
        {
            _castomerService = castomerService;
        }

        // GET: api/<CastomerController>
        [HttpGet]
        public IEnumerable<Castomer> Get()
        {
           return _castomerService.GetAll();
        }

        //// GET api/<CastomerController>/5
        [HttpGet("{id}")]
        public Castomer Get(int id)
        {
            return _castomerService.GetById(id);
        }

        // POST api/<CastomerController>
        [HttpPost]
        public void Post([FromBody] Castomer newCastomer)
        {
            _castomerService.AddValue(newCastomer);
        }

        // PUT api/<CastomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name, string phone)
        {
            _castomerService.PutValue(id, name, phone);
        }

        // DELETE api/<CastomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _castomerService.Delete(id);
        }
    }
}
