using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Models
{
    public record ZoneLocationModel
    {
        [Key]
        public int id { get; init; }
        public double longitude { get; init; }
        public double latitude { get; init; }
        public int shapeId { get; init; }
    }
}
