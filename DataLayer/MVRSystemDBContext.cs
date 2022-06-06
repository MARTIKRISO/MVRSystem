using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OnlineShopDBContext : DbContext
    {
        public OnlineShopDBContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"id=MVRSystemDB.mssql.somee.com;packet size=4096;user id=mshkodrov_SQLLogin_1;pwd=qrktrucpmy;data source=MVRSystemDB.mssql.somee.com;persist security info=False;initial catalog=MVRSystemDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //public DbSet<Customer> Customers { get; set; }

        //public DbSet<Product> Products { get; set; }

        //public DbSet<Order> Orders { get; set; }
    }
}
