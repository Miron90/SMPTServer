using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Dtos
{
    public class ZoneLocationDto
    {
        public double longitude { get; init; }
        public double latitude { get; init; }
        public int shapeId { get; init; }
    }
}
