using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectMonoService.Interfaces;
using ProjectMonoService.Models;

namespace ProjectMonoService.Migrations
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options)
        { }


        public DbSet<VehicleMake> VehicleMakes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleMake>().ToTable("VehicleMake")
                .HasMany(p => p.VehicleModels)
                .WithOne(p => p.VehicleMake)
                .HasForeignKey(p => p.MakeId);
            modelBuilder.Entity<VehicleModel>().ToTable("VehicleModel");
                
        }

    }
}
