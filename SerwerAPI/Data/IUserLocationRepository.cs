using SerwerAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Data
{
    public interface IUserLocationRepository
    {
        void Add<UsersLocationModel>(UsersLocationModel userLocation);
        Task<IEnumerable<UsersLocationModel>> GetUsersLocations();
        Task<UsersLocationModel> GetUserLocation(string name);
        Task<bool> SaveLocation(UserLocationDto usersLocation);

    }
}
