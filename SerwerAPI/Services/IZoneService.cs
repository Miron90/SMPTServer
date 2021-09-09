using SerwerAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Services
{
    public interface IZoneService
    {

        public Task<IEnumerable<ZoneLocationDto>> GetZonesLocations();
    }
}
