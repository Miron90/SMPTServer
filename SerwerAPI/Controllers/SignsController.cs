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
    public class SignsController : Controller
    {
        
            private readonly ISignsService _service;

            public SignsController(ISignsService service)
            {
                _service = service;
            }


            [HttpGet]
            public async Task<IActionResult> GetSigns()
            {
                IEnumerable<SignsDto> usersLocations;
                try
                {
                    usersLocations = await _service.GetSigns();
                }
                catch (Exception e)
                {
                    return BadRequest("" + e);
                }

                return Ok(usersLocations);
            }
    }
}
