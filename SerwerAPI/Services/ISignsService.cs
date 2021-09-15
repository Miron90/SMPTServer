using SerwerAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Services
{
    public interface ISignsService
    {
        Task<IEnumerable<SignsDto>> GetSigns();
        Task<bool> AddSign(SignUploadDto signDto);
        Task<IEnumerable<SignDataDto>> GetSignsOrderedBy();
        Task<string> GetSVGSignCode(string signCode);
    }
}
