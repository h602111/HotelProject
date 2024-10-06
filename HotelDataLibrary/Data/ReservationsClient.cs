using System;
using System.Collections.Generic;
using System.Linq;

using HotelDataLibrary.Database;
using HotelDataLibrary.Models;

namespace HotelDataLibrary.Data {
    public class ReservationsClient {

        DatabaseContext Context;

        public ReservationsClient() {
            Context = new DatabaseContext();
        }

        public List<Reservation> GetAllReservations() {
            return Context.Reservations.ToList();
        }

        public bool DeleteReservation(Reservation reservation) {
            Context.Reservations.Remove(reservation);

            int Result = Context.SaveChanges();

            return Result > 0;
        }

        public bool CreateReservation(Reservation reservation) {
            Context.Add(reservation);

            int Result = Context.SaveChanges();

            return Result > 0;
        }
    }
}
