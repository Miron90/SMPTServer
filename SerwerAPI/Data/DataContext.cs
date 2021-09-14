using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DataContext() { }

        public DbSet<UsersLocationModel> UsersLocation { get; set; }

        public DbSet<ZoneLocationModel> ZoneLocation { get; set; }
        public DbSet<SignsModel> Signs { get; set; }
        public DbSet<SignsDataModel> SignsData { get; set; }
        public DbSet<OldUsersLocationModel> OldUsersData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=C:\APIDatabase\UsersLocation.db");
            }
        }


    }
}
