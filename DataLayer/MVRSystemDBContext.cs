using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class MVRSystemDBContext : DbContext
    {
        public MVRSystemDBContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"id=MVRSystemDB.mssql.somee.com;packet size=4096;user id=mshkodrov_SQLLogin_1;pwd=qrktrucpmy;data source=MVRSystemDB.mssql.somee.com;persist security info=False;initial catalog=MVRSystemDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Passport> Passports { get; set; }
        public DbSet<Visa> Visas { get; set; }
        public DbSet<DrivingLicense> DrivingLicenses { get; set; }
    }
}
