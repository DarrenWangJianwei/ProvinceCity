using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProvinceCity.Models;

namespace ProvinceCity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        builder.Entity<City>().Property(m => m.CityId).IsRequired();

        builder.Entity<Province>().Property(m => m.ProvinceCode).IsRequired();

        builder.Entity<Province>().ToTable("Province");
        builder.Entity<City>().ToTable("City");

        builder.Seed();
        }

        public DbSet<Province> Province { get; set; }
        public DbSet<City> City { get; set; }
    }
}
