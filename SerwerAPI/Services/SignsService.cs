using SerwerAPI.Data;
using SerwerAPI.Dtos;
using SerwerAPI.Models;
using SerwerAPI.staticMembers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwerAPI.Services
{
    public class SignsService: ISignsService
    {
        private readonly ISignsRepository _repo;

        public SignsService(ISignsRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<SignsDto>> GetSigns()
        {
            var signsModel = await _repo.GetSigns();

            var signsDto = new List<SignsDto>();
            foreach (SignsModel model in signsModel)
            {
                signsDto.Add(new SignsDto
                {
                    signSVG = JSEngine.runEngine(model.signCode).GetCompletionValue().ToString(),
                    signId = model.id,
                    signCode= model.signCode,
                    latitude = model.latitude,
                    longitude = model.longitude
                });
            }

            return signsDto.AsEnumerable();
        }
    }
}
