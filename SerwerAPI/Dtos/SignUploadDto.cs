using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Dtos
{
    public record SignUploadDto
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string signCode { get; set; }
    }
}
