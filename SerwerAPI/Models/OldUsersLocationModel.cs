using System;
using System.ComponentModel.DataAnnotations;

namespace SerwerAPI
{
    public record OldUsersLocationModel
    {
        [Key]
        public int id { get; set; }
        public double latitude { get; set; }

        public double longtitude { get; set; }
        public string name { get; set; }

        public DateTime lastUpdatedTime { get;set; }
    }
}
