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

        public Task AddZoneModel(List<ZoneLocationModel> zonesLocationsModel)
        {
            foreach(ZoneLocationModel model in zonesLocationsModel)
            {
                _context.ZoneLocation.Add(model);
            }
            
            return Task.Run(() => _context.SaveChanges());
        }

        public int GetLastZoneId()
        {
            var zone = _context.ZoneLocation.OrderByDescending(zone => zone.shapeId).FirstOrDefault();
            if (zone == null)
            {
                return 1;
            }
            else {
                return zone.shapeId;
            }
        }

        public Task<IEnumerable<ZoneLocationModel>> GetZonesLocations()
        {
            return Task.Run(() => _context.ZoneLocation.OrderBy(zone => zone.id).OrderBy(zone => zone.shapeId).ToList().AsEnumerable());
            throw new NotImplementedException();
        }
    }
}
