using SerwerAPI.Data;
using SerwerAPI.Dtos;
using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Services
{
    public class ZoneService : IZoneService
    {
        private readonly IZoneLocationRepository _repo;

        public ZoneService(IZoneLocationRepository repo)
        {
            _repo = repo;
        }

        public async Task AddZone(ZoneAddDto[] zone)
        {
            var mShapeId = _repo.GetLastZoneId();
            var zonesLocationsModel = new List<ZoneLocationModel>();
            foreach (ZoneAddDto dto in zone)
            {
                zonesLocationsModel.Add(new ZoneLocationModel
                {
                    longitude = dto.mLongitude,
                    latitude = dto.mLatitude,
                    shapeId = mShapeId
                });
            }
            await _repo.AddZoneModel(zonesLocationsModel);
        }

        public async Task<IEnumerable<ZoneLocationDto>> GetZonesLocations()
        {
            var zonesLocations = await _repo.GetZonesLocations();

            var zonesLocationsDto = new List<ZoneLocationDto>();
            foreach (ZoneLocationModel dto in zonesLocations)
            {
                zonesLocationsDto.Add(new ZoneLocationDto
                {
                    shapeId = dto.shapeId,
                    latitude = dto.latitude,
                    longitude = dto.longitude
                });
            }

            return zonesLocationsDto.AsEnumerable();
        }
    }
}
