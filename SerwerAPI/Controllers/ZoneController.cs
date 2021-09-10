using Microsoft.AspNetCore.Mvc;
using SerwerAPI.Dtos;
using SerwerAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoneController: ControllerBase
    {
        private readonly IZoneService _service;

        public ZoneController(IZoneService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetZonesLocations()
        {



            IEnumerable<ZoneLocationDto> zoneLocations;
            try
            {
                zoneLocations = await _service.GetZonesLocations();
            }
            catch (Exception e)
            {
                return BadRequest("" + e);
            }

            return Ok(zoneLocations);
            /*var db = new UsersLocationContext();
            Console.WriteLine(db.UsersLocation.ToList());
            return db.UsersLocation.ToList();*/
        }
    }
}
