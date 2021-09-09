using Microsoft.AspNetCore.Mvc;
using SerwerAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<UserLocationDto>> GetUsersLocations();
        public Task<bool> UpdateUserLocation([FromBody] UserLocationDto userLocationDto);
    }
}
