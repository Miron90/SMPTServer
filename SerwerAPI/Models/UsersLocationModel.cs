using System;
using System.ComponentModel.DataAnnotations;

namespace SerwerAPI
{
    public record UsersLocationModel
    {
        public double latitude { get; set; }

        public double longtitude { get; set; }
        [Key]
        public string name { get; set; }

        public DateTime updatedTime { get; set; }
    }
}
