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
            IEnumerable<SignsDto> signs;
            try
            {
                signs = await _service.GetSigns();
            }
            catch (Exception e)
            {
                return BadRequest("" + e);
            }

            return Ok(signs);
        }

        [HttpPost]
        public async Task<IActionResult> UploadSign([FromBody] SignUploadDto signDto)
        {
            bool added;
            try
            {
                added = await _service.AddSign(signDto);
            }
            catch (Exception e)
            {
                return BadRequest("" + e);
            }
            if (added) { 
            return Ok("added");
            }
            else
            {
                return BadRequest("could not add sign");
            }
        }
    }
}
