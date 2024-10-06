﻿// <auto-generated />
using System;
using CustomerWebApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CustomerWebApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200227193501_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CustomerWebApp.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Roomnr")
                        .HasColumnType("integer");

                    b.Property<int?>("RoomnrNavigationRoomnr")
                        .HasColumnType("integer");

                    b.Property<int?>("Usernr")
                        .HasColumnType("integer");

                    b.Property<int?>("UsernrNavigationUsernr")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoomnrNavigationRoomnr");

                    b.HasIndex("UsernrNavigationUsernr");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CustomerWebApp.Room", b =>
                {
                    b.Property<int>("Roomnr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("boolean");

                    b.Property<int>("Numberofbeds")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("Roomsize")
                        .HasColumnType("integer");

                    b.HasKey("Roomnr");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Roomnr = 1,
                            Available = true,
                            Numberofbeds = 3,
                            Price = 1000,
                            Roomsize = 10
                        },
                        new
                        {
                            Roomnr = 2,
                            Available = true,
                            Numberofbeds = 2,
                            Price = 800,
                            Roomsize = 6
                        },
                        new
                        {
                            Roomnr = 3,
                            Available = true,
                            Numberofbeds = 4,
                            Price = 1500,
                            Roomsize = 15
                        },
                        new
                        {
                            Roomnr = 4,
                            Available = true,
                            Numberofbeds = 2,
                            Price = 900,
                            Roomsize = 8
                        },
                        new
                        {
                            Roomnr = 5,
                            Available = true,
                            Numberofbeds = 3,
                            Price = 3000,
                            Roomsize = 20
                        },
                        new
                        {
                            Roomnr = 6,
                            Available = true,
                            Numberofbeds = 1,
                            Price = 600,
                            Roomsize = 5
                        });
                });

            modelBuilder.Entity("CustomerWebApp.User", b =>
                {
                    b.Property<int>("Usernr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Usernr");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CustomerWebApp.Reservation", b =>
                {
                    b.HasOne("CustomerWebApp.Room", "RoomnrNavigation")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomnrNavigationRoomnr");

                    b.HasOne("CustomerWebApp.User", "UsernrNavigation")
                        .WithMany("Reservations")
                        .HasForeignKey("UsernrNavigationUsernr");
                });
#pragma warning restore 612, 618
        }
    }
}
