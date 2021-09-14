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
            _context.SaveChanges();
            return Task.Run(() => true);
        }

        public Task<IEnumerable<SignsModel>> GetSigns()
        {
            return Task.Run(() => _context.Signs.ToList().AsEnumerable());
        }
    }
}
