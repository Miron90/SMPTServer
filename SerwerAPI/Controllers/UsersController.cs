using Jering.Javascript.NodeJS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SerwerAPI.Dtos;
using SerwerAPI.Models;
using SerwerAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsersLocations()
        {
            var services = new ServiceCollection();
            services.AddNodeJS();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            INodeJSService nodeJSService = serviceProvider.GetRequiredService<INodeJSService>();

            /*string result = await StaticNodeJSService.InvokeFromStringAsync<string>("module.exports = (callback) => {var msd new new ms.Symbol('fgpewrh--mt', {size: 35,quantity: 200, staffComments: 'for reinforcements'.toUpperCase(),additionalInformation: 'added support for JJ'.toUpperCase(),direction: (750 * 360) / 6400,type: 'machine gun'.toUpperCase(),dtg: '30140000ZSEP97', location: '0900000.0E570306.0N'}).asSVG();callback(null, msd);}", args: new[] { "success" });

            Console.WriteLine(result);*/

            IEnumerable<UserLocationDto> usersLocations;
            try
            {
                usersLocations = await _service.GetUsersLocations();
            }catch(Exception e)
            {
                return BadRequest(""+e);
            }

            return Ok(usersLocations);
            /*var db = new UsersLocationContext();
            Console.WriteLine(db.UsersLocation.ToList());
            return db.UsersLocation.ToList();*/
        }


        // POST api/<MapController>
        [HttpPost]
        public async Task<IActionResult> CreateLocation([FromBody] UserLocationDto userLocationDto)
        {
            bool added = false;

            try
            {
                added = await _service.UpdateUserLocation(userLocationDto);
            }catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
            if (added) return Ok();

            return BadRequest("Could not add the place");

            /*var db = new UsersLocationContext();
            UsersLocationModel userLocationModel = db.UsersLocation.Where(u => u.name.Equals(locationDto.name)).SingleOrDefault();

            if (userLocationModel == null)
            {
                userLocationModel = new();

                userLocationModel.name = locationDto.name;
                userLocationModel.latitude = locationDto.latitude;
                userLocationModel.longtitude = locationDto.longtitude;
                db.Add(userLocationModel);
            }
            else
            {
                userLocationModel.latitude = locationDto.latitude;
                userLocationModel.longtitude = locationDto.longtitude;
            }
            db.SaveChanges();
            return Ok("zedytowano");*/
        }

    }
}
