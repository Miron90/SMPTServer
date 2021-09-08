using SerwerAPI;
using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



public class InMemLocationRepository : ILocationRepository
{
    private readonly List<Location> locations = new()
    {
        new Location { latitude = 56.12, longtitude = 12.52, name = "Andrew" }
    };

    public void CreateLocalization(Location location)
    {
        locations.Add(location);
    }

    public IEnumerable<Location> GetLocations()
    {
            return locations;
    }

}