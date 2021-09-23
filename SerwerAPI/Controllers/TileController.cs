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
    public class TileController : ControllerBase
    {
        public TileController()
        { }

        [HttpGet("{zoom}/{x}/{y}")]
        public IActionResult Get(int zoom, int x, int y)
        {
            try
            {
                var filePath = "C:\\\\APIDatabase\\warsaw\\4uMaps" + "\\" + zoom + "\\" + x + "\\" + y + ".png";
                Byte[] b = null;
                try
                {
                    b = System.IO.File.ReadAllBytes(filePath);   // You can use your own method over here.
                }catch(Exception e)
                {

                }
                return File(b, "image/png");
            }
            catch (Exception e)
            {
                return NoContent();
            }

        }
    }
}
