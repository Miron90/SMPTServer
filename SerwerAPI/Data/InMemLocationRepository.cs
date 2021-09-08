using SerwerAPI;
using SerwerAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



public class InMemLocationRepository : ILocationRepository
{
    private readonly List<Location> locations = new()
    {
        new Location { latitude = 52.242935, longtitude = 20.9698317, name = "Andrew" },
        new Location { latitude = 52.243935, longtitude = 20.9658317, name = "Math" },
        new Location { latitude = 52.241935, longtitude = 20.9628317, name = "Gick" }
    };

    public void CreateLocalization(Location location)
    {
        locations.Add(location);
    }

    public Location GetLocalization(string name)
    {
        return locations.Where(location => location.name == name).SingleOrDefault();
    }

    public void SaveLocalization(Location location, bool remove)
    {
        int index = locations.IndexOf(location);
        if(remove) locations.RemoveAt(index);
        locations.Add(location);
    }

    public IEnumerable<Location> GetLocations()
    {
            return locations;
    }

}