using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Data
{
    public class SignsRepository : ISignsRepository
    {
        private readonly DataContext _context;

        public SignsRepository(DataContext context)
        {
            _context = context;
        }

        public Task<bool> AddSign(SignsModel model)
        {
            _context.Signs.Add(model);
            var signsData = _context.SignsData.Where(e => e.signCode == model.signCode).SingleOrDefault();
            if (signsData != null)
            {
                signsData.count++;
                _context.SignsData.Update(signsData);
            }
            _context.SaveChanges();
            return Task.Run(() => true);
        }

        public SignsDataModel GetSignByID(string id)
        {
            return _context.SignsData.Where(e => e.signCode == id).FirstOrDefault();
        }

        public void AddSignToSignsData(SignsDataModel model)
        {
            _context.SignsData.Add(model);
            _context.SaveChanges();
        }

        public Task<IEnumerable<SignsModel>> GetSigns()
        {
            return Task.Run(() => _context.Signs.ToList().AsEnumerable());
        }

        public Task<IEnumerable<SignsDataModel>> GetSignsOrderedBy()
        {
            return Task.Run(() => _context.SignsData.OrderByDescending(e => e.count).ToList().AsEnumerable());
        }
    }
}
