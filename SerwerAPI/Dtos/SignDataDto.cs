using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Dtos
{
    public class SignDataDto
    {
        public string signSVG { get; set; }
        public string signCode { get; set; }
        public int count { get; set; }
    }
}
