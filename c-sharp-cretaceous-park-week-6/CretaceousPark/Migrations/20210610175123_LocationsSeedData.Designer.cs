﻿// <auto-generated />
using CretaceousPark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CretaceousPark.Migrations
{
    [DbContext(typeof(CretaceousParkContext))]
    [Migration("20210610175123_LocationsSeedData")]
    partial class LocationsSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CretaceousPark.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Gender = "Female",
                            Name = "Matilda",
                            Species = "Woolly Mammoth"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 10,
                            Gender = "Female",
                            Name = "Rexie",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Gender = "Female",
                            Name = "Matilda",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Gender = "Male",
                            Name = "Pip",
                            Species = "Shark"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 22,
                            Gender = "Male",
                            Name = "Bartholomew",
                            Species = "Dinosaur"
                        });
                });

            modelBuilder.Entity("CretaceousPark.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TerrainType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Weather")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Name = "Swamp Lands",
                            TerrainType = "swamp",
                            Weather = "rainy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
