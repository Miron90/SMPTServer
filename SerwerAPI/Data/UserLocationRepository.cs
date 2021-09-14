using SerwerAPI.Dtos;
using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Data
{
    public class UserLocationRepository : IUserLocationRepository
    {
        private readonly DataContext _context;

        public UserLocationRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<UsersLocationModel>(UsersLocationModel userLocation)
        {
            _context.Add(userLocation);
        }

        public Task<UsersLocationModel> GetUserLocation(string name)
        {
            return Task.Run(() => _context.UsersLocation.Where(u => u.name.Equals(name)).SingleOrDefault());
        }

        public Task<IEnumerable<UsersLocationModel>> GetUsersLocations()
        {

            return Task.Run(() => _context.UsersLocation.ToList().AsEnumerable());
        }

        public Task<bool> SaveLocation(UserLocationDto userLocation)
        {
            UsersLocationModel userLocationModel = _context.UsersLocation.Where(u => u.name.Equals(userLocation.name)).SingleOrDefault();
            if (userLocationModel == null)
            {
                userLocationModel = new();

                userLocationModel.name = userLocation.name;
                userLocationModel.latitude = userLocation.latitude;
                userLocationModel.longtitude = userLocation.longitude;
                userLocationModel.updatedTime = DateTime.Now;
                _context.Add(userLocationModel);
            }
            else
            {
                userLocationModel.latitude = userLocation.latitude;
                userLocationModel.longtitude = userLocation.longitude;
                userLocationModel.updatedTime = DateTime.Now;
            }
            _context.SaveChanges();
            return Task.Run(() => true);
        }
    }
}
