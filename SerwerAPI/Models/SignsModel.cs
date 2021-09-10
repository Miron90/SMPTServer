using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Models
{
    public record SignsModel
    {
        public int id { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string signCode { get; set; }

    }
}
