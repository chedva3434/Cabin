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
    public class CastomerController : ControllerBase
    {
        private readonly ICastomerService _castomerService;

        private readonly IMapper _mapper;

        public CastomerController(ICastomerService castomerService, IMapper mapper)
        {
            _castomerService = castomerService;
            _mapper = mapper;
        }

        // GET: api/<CastomerController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _castomerService.GetAllAsync();
            var listDto = _mapper.Map<IEnumerable<CastomerDto>>(list);
            return Ok(listDto);
        }

        //// GET api/<CastomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var cabin = _castomerService.GetByIdAsync(id);
            var cabinDto = _mapper.Map<CastomerDto>(cabin);
            return Ok(cabinDto);
        }

        // POST api/<CastomerController>
        [HttpPost]
        public void Post([FromBody] CastomerPostModel value)
        {
            var CastomerToAdd = new Castomer { name=value.name,phone=value.phone };
            _castomerService.AddValueAsync(CastomerToAdd);
        }

        // PUT api/<CastomerController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Castomer value)
        {
            _castomerService.PutValueAsync(value);
        }

        // DELETE api/<CastomerController>/5
        [HttpDelete("{id}")]
        public void Delete(Castomer castomer)
        {
           _castomerService.DeleteAsync(castomer);
        }
    }
}
