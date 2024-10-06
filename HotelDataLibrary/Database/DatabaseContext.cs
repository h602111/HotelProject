using System;

using Microsoft.EntityFrameworkCore;

using HotelDataLibrary.Models;
using HotelDataLibrary.Migrations;

namespace HotelDataLibrary.Database {
    public class DatabaseContext : DbContext {


        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=tcp:dat154gruppe7.database.windows.net,1433;Initial Catalog=Dat154Tanvir;Persist Security Info=False;User ID=h602605;Password=EagleBison3400;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    }
}
