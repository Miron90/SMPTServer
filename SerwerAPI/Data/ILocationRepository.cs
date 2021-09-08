using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Models
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetLocations();
        Location GetLocalization(string name);

        public void SaveLocalization(Location location, bool remove);

        void CreateLocalization(Location location);
    }
}
