using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagementCabin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinController : ControllerBase
    {
        static List<Cabin> CabinList = new List<Cabin>();
        // GET: api/<CabinController>
        [HttpGet]
        public IEnumerable< Cabin> Get()
        {
      
            return CabinList;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var order = CabinList.Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        // POST api/<CabinController>
        [HttpPost]
        public void Post([FromBody] Cabin newCabin)
        {
            CabinList.Add(newCabin);
        }

        // PUT api/<CabinController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string? name, double price)
        {
            for (int i = 0; i < CabinList.Count; i++)
            {
                if (CabinList[i].Id == id)
                {
                    if (name!=null)
                    {
                        CabinList[i].Name = name;
                        CabinList[i].Price = price;
                    }                    
                }
            }
        }

        // DELETE api/<CabinController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < CabinList.Count; i++)
            {
                if (CabinList[i].Id == id)
                {
                    CabinList.RemoveAt(i);
                }
            }
        }
    }
}
