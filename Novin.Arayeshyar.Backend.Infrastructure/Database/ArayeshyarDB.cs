using Microsoft.EntityFrameworkCore;
using Novin.Arayeshyar.Backend.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Infrastructure.Database
{
    public class ArayeshyarDB : DbContext
    {
     

        public DbSet<SystemAdmin>  systemAdmins { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<BarberShop> barberShops { get; set; }
        public DbSet<BarberOwner> BarberOwners { get; set; }
        public DbSet<Barber> barbers{ get; set; }

        public ArayeshyarDB(DbContextOptions<ArayeshyarDB> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SystemAdmin>().HasKey(m => m.Usernmae);
            modelBuilder.Entity<Customer>().HasKey(m => m.MobileNumber);
            modelBuilder.Entity<BarberShop>().HasKey(m => m.ID);
            modelBuilder.Entity<BarberOwner>().HasKey(m => m.MobileNumber);
            modelBuilder.Entity<Barber>().HasKey(m => m.MobileNumber);
                
        }



    }
}
