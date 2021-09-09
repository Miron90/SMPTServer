using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UsersLocationModel> UsersLocation { get; set; }

        public DbSet<ZoneLocationModel> ZoneLocation { get; set; }


    }
}
