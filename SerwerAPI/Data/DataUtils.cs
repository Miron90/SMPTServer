using SerwerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Data
{
    public class DataUtils
    {
        private DataContext _context;

        public DataUtils()
        {
        }

        public void checkOldRecord()
        {
            _context = new DataContext();
            foreach (UsersLocationModel model in _context.UsersLocation)
            {
                if ((DateTime.Now - model.updatedTime).TotalMinutes > 2)
                {
                    _context.Remove(model);
                }
            }
            _context.SaveChanges();
        }


    }
}
