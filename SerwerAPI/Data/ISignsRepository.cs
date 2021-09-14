using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Data
{
    public interface ISignsRepository
    {
        Task<IEnumerable<SignsModel>> GetSigns();
        Task<bool> AddSign(SignsModel model);
        SignsDataModel GetSignByID(string id);
        void AddSignToSignsData(SignsDataModel model);
        Task<IEnumerable<SignsDataModel>> GetSignsOrderedBy();
    }
}
