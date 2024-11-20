using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinController : ControllerBase
    {
        private readonly IDataContext _context;

        public CabinController(IDataContext context)
        {
            _context = context;
        }



        // GET: api/<CabinController>
        [HttpGet]
        public IEnumerable< Cabin> Get()
        {
      
            return _context.Cabins;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var order = _context.Cabins.Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        // POST api/<CabinController>
        [HttpPost]
        public void Post([FromBody] Cabin newCabin)
        {
            _context.Cabins.Add(newCabin);
        }

        // PUT api/<CabinController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string? name, double price)
        {
            for (int i = 0; i < _context.Cabins.Count; i++)
            {
                if (_context.Cabins[i].Id == id)
                {
                    if (name!=null)
                    {
                        _context.Cabins[i].Name = name;
                        _context.Cabins[i].Price = price;
                    }                    
                }
            }
        }

        // DELETE api/<CabinController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _context.Cabins.Count; i++)
            {
                if (_context.Cabins[i].Id == id)
                {
                    _context.Cabins.RemoveAt(i);
                }
            }
        }
    }
}
