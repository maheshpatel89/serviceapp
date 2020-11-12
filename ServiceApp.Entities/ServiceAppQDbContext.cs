using Microsoft.EntityFrameworkCore;
using ServiceApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Entities
{
    public class ServiceAppQDbContext : DbContext
    {
        public ServiceAppQDbContext(DbContextOptions<ServiceAppQDbContext> options)
                 : base(options)
        {
        }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<CountryMaster> Country { get; set; }
        public DbSet<StateMaster> State { get; set; }
        public DbSet<CityMaster> City { get; set; }
        public DbSet<ServiceTypeMaster> ServiceType { get; set; }
        public DbSet<ServiceMaster> Service { get; set; }

        public DbSet<AccountMaster> Account { get; set; }
    }
}
