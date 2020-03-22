﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectMonoService.Models;

namespace ProjectMonoService.Migrations
{
    [DbContext(typeof(VehicleDbContext))]
    [Migration("20200322112912_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectMonoService.Models.VehicleMake", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abrv")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("VehicleMake");
                });

            modelBuilder.Entity("ProjectMonoService.Models.VehicleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abrv")
                        .IsRequired();

                    b.Property<Guid>("MakeId");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("VehicleModel");
                });

            modelBuilder.Entity("ProjectMonoService.Models.VehicleModel", b =>
                {
                    b.HasOne("ProjectMonoService.Models.VehicleMake", "VehicleMake")
                        .WithMany("VehicleModels")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
