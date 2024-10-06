using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerWebApp.Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Reservation>().HasData(
            //  new
            //  {

            //  });

            modelBuilder.Entity<Room>().HasData(
             new
             {
                 Roomnr = 1,
                 Numberofbeds = 3,
                 Roomsize = 10,
                 Price = 1000,
                 Available = true
             }, 
             new
             {
                 Roomnr = 2,
                 Numberofbeds = 2,
                 Roomsize = 6,
                 Price = 800,
                 Available = true
             },
              new
              {
                  Roomnr = 3,
                  Numberofbeds = 4,
                  Roomsize = 15,
                  Price = 1500,
                  Available = true
              },
              new
              {
                  Roomnr = 4,
                  Numberofbeds = 2,
                  Roomsize = 8,
                  Price = 900,
                  Available = true
              },
               new
               {
                   Roomnr = 5,
                   Numberofbeds = 3,
                   Roomsize = 20,
                   Price = 3000,
                   Available = true
               },
                new
                {
                    Roomnr = 6,
                    Numberofbeds = 1,
                    Roomsize = 5,
                    Price = 600,
                    Available = true
                }
            );
            //modelBuilder.Entity<User>().HasData(
            //  new
            //  {
            //  });
        }
    }
}
