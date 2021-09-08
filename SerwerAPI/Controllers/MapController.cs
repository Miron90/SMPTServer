using Microsoft.AspNetCore.Mvc;
using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SerwerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {




        private readonly ILocationRepository _localizationRepo;

        public MapController(ILocationRepository repository)
        {
            _localizationRepo = repository;
        }
        // GET: api/<MapController>
        [HttpGet]
        public IEnumerable<Location> Get()
        {
            return _localizationRepo.GetLocations();
        }

        // GET api/<MapController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MapController>
        [HttpPost]
        /* public void Post(Location value)
         {
             Console.WriteLine("it work " + value);
         }*/
        public ActionResult<LocationDto> CreateLocation([FromBody]  LocationDto locationDto)
        {
            Location location = new()
            {
                name = locationDto.name,
                latitude = locationDto.latitude,
                longtitude = locationDto.longtitude
            };

            _localizationRepo.CreateLocalization(location);
            return Ok("utworzono");
        }

        // PUT api/<MapController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MapController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
