using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Dtos
{
    public record SignsDto
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string signSVG { get; set; }
        public string signCode { get; set; }
        public int signId { get; set; }
    }
}
