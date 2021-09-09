using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Dtos
{
    public record UserLocationDto
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
