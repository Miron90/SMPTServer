using SerwerAPI.Data;
using SerwerAPI.Dtos;
using SerwerAPI.Helpers;
using SerwerAPI.Models;
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
        private readonly IJSEngine _engine;

        public SignsService(ISignsRepository repo, IJSEngine jsengine)
        {
            _repo = repo;
            _engine = jsengine;
        }

        public async Task<bool> AddSign(SignUploadDto signDto)
        {
            SignsModel model = new()
            {
                latitude = Math.Round(signDto.latitude,5),
                longitude = Math.Round(signDto.longitude,5),
                signCode = signDto.signCode
            };
            if (await _repo.AddSign(model)) return true;
            else return false;
        }

        public async Task<IEnumerable<SignsDto>> GetSigns()
        {
            var signsModel = await _repo.GetSigns();

            var signsDto = new List<SignsDto>();
            foreach (SignsModel model in signsModel)
            {
                var signSVG = _repo.GetSignByID(model.signCode);
                string svg;
                if (signSVG == null)
                {
                    svg = _engine.runEngine(model.signCode).GetCompletionValue().ToString();
                    _repo.AddSignToSignsData(new SignsDataModel
                    {
                        signCode = model.signCode,
                        SVGCode = svg,
                        count = 1
                    }) ; 
                }
                else
                {
                    svg = signSVG.SVGCode;
                }
                signsDto.Add(new SignsDto
                {
                    signSVG = svg,
                    signId = model.id,
                    signCode= model.signCode,
                    latitude = model.latitude,
                    longitude = model.longitude
                });
            }

            return signsDto.AsEnumerable();
        }

        public async Task<IEnumerable<SignDataDto>> GetSignsOrderedBy()
        {
            IEnumerable<SignsDataModel> signsModel = await _repo.GetSignsOrderedBy();

            var signsDto = new List<SignDataDto>();
            foreach (SignsDataModel model in signsModel)
            {
                signsDto.Add(new SignDataDto
                {
                    signSVG = model.SVGCode,
                    signCode=model.signCode,
                    count=model.count
                });
            }
            return signsDto;
        }
    }
}
