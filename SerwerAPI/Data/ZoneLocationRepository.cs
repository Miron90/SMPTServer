using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Data
{
    public class ZoneLocationRepository : IZoneLocationRepository
    {
        private readonly DataContext _context;

        public ZoneLocationRepository(DataContext context)
        {
            _context = context;
        }
        public Task<IEnumerable<ZoneLocationModel>> GetZonesLocations()
        {
            return Task.Run(() => _context.ZoneLocation.OrderBy(zone=>zone.id).OrderBy(zone => zone.shapeId).ToList().AsEnumerable());
            throw new NotImplementedException();
        }
    }
}
