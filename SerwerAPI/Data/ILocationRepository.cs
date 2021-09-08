using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Models
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetLocations();

        void CreateLocalization(Location location);
    }
}
