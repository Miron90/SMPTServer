using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Data
{
    public interface IZoneLocationRepository
    {
        Task<IEnumerable<ZoneLocationModel>> GetZonesLocations();
    }
}
