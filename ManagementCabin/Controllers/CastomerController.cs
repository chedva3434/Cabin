using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastomerController : ControllerBase
    {
        static List<Castomer> castomers = new List<Castomer>();
        // GET: api/<CastomerController>
        [HttpGet]
        public List<Castomer> Get()
        {
           return castomers;
        }

        // GET api/<CastomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var order = castomers.Find(x => x.id == id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }


        // POST api/<CastomerController>
        [HttpPost]
        public void Post([FromBody] Castomer newCastomer)
        {
            castomers.Add(newCastomer);
        }

        // PUT api/<CastomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name,string phone)
        {
            for (int i = 0; i < castomers.Count; i++)
            {
                if (castomers[i].id == id)
                {
                    castomers[i].name = name;
                    castomers[i].phone = phone;
                }
            }
        }

        // DELETE api/<CastomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < castomers.Count; i++)
            {
                if (castomers[i].id == id)
                {
                    castomers.RemoveAt(i);
                    return;
                }

            }
        }
    }
}
