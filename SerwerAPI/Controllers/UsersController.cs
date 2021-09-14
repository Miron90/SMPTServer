
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SerwerAPI.Dtos;
using SerwerAPI.Models;
using SerwerAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jint;

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
            IEnumerable<UserLocationDto> usersLocations;
            try
            {
                usersLocations = await _service.GetUsersLocations();
            }catch(Exception e)
            {
                return BadRequest(""+e);
            }

            return Ok(usersLocations);
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
            if (added) return Ok("added");

            return BadRequest("Could not add the place");
        }

    }
}
