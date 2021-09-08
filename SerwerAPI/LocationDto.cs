using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI
{
    public record LocationDto
    {
        public double latitude { get; init; }

        public double longtitude { get; init; }

        public string name { get; init; }
    }
}
