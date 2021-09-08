using System;

namespace SerwerAPI
{
    public record Location
    {
        public double latitude { get; set; }

        public double longtitude { get; set; }

        public string name { get; set; }
    }
}
