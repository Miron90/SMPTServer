using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Models
{
    public record SignsDataModel
    {
        [Key]
        public string signCode { get; set; }
        public string SVGCode { get; set; }
        public int count { get; set; }
    }
}
