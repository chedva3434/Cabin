using AutoMapper;
using Clean.Core.Models;
using Clean.Core.Service;
using ManagementCabin.Core.DTOs;
using ManagementCabin.Models;
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

        private readonly IMapper _mapper;

        public CabinController(ICabinService cabinService, IMapper mapper)
        {
            _cabinService = cabinService;
            _mapper = mapper;
        }

        // GET: api/<CabinController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _cabinService.GetAllAsync();
            var listDto = _mapper.Map<CabinDto>(list);
            return Ok(listDto);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var cabin= _cabinService.GetByIdAsync(id);
            var cabinDto=_mapper.Map<CabinDto>(cabin);
            return Ok(cabinDto);
        }

        // POST api/<CabinController>
        [HttpPost]
        public async Task Post([FromBody] CabinPostModel value)
        {
            var CabinToAdd=new Cabin {Name=value.Name,Price=value.Price,status=value.status };
           await _cabinService.AddValueAsync(CabinToAdd);
        }

        // PUT api/<CabinController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Cabin value)
        {
           _cabinService.PutValueAsync(value);
        }

        // DELETE api/<CabinController>/5
        [HttpDelete("{id}")]
        public void Delete(Cabin cabin)
        {
           _cabinService.DeleteAsync(cabin);
        }
    }
}
