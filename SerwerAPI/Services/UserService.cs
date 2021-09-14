using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SerwerAPI.Data;
using SerwerAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLocationRepository _repo;

        public UserService(IUserLocationRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<UserLocationDto>> GetUsersLocations()
        {
            var usersLocations = await _repo.GetUsersLocations();

            var usersLocationsModel = new List<UserLocationDto>();
            foreach(UsersLocationModel dto in usersLocations)
            {
                usersLocationsModel.Add(new UserLocationDto
                {
                    name = dto.name,
                    latitude=Math.Round(dto.latitude,5),
                    longitude=Math.Round(dto.longtitude,5)
                });
            }

            return usersLocationsModel.AsEnumerable();
        }

        public async Task<bool> UpdateUserLocation([FromBody] UserLocationDto userLocationDto)
        {
            if (await _repo.SaveLocation(userLocationDto)) return true;

            throw new System.Exception($"Updating location failed on save");
        }
    }
}
