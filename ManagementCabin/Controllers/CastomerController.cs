using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastomerController : ControllerBase
    {
        private readonly IDataContext _context;

        public CastomerController(IDataContext context)
        {
            _context = context;
        }


        // GET: api/<CastomerController>
        [HttpGet]
        public IEnumerable<Castomer> Get()
        {
           return _context.Castomers;
        }

        // GET api/<CastomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var order = _context.Castomers.Find(x => x.id == id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }


        // POST api/<CastomerController>
        [HttpPost]
        public void Post([FromBody] Castomer newCastomer)
        {
            _context.Castomers.Add(newCastomer);
        }

        // PUT api/<CastomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name,string phone)
        {
            for (int i = 0; i < _context.Castomers.Count; i++)
            {
                if (_context.Castomers[i].id == id)
                {
                    _context.Castomers[i].name = name;
                    _context.Castomers[i].phone = phone;
                }
            }
        }

        // DELETE api/<CastomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _context.Castomers.Count; i++)
            {
                if (_context.Castomers[i].id == id)
                {
                    _context.Castomers.RemoveAt(i);
                    return;
                }

            }
        }
    }
}
