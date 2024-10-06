using System;
using System.Collections.Generic;
using System.Linq;

using HotelDataLibrary.Database;
using HotelDataLibrary.Models;

namespace HotelDataLibrary.Data {
    public class RoomsClient {

        DatabaseContext Context;

        public RoomsClient() {
            Context = new DatabaseContext();
        }

        public List<Room> GetAllRooms() {
            return Context.Rooms.ToList<Room>();
        }

        public bool DeleteRoom(Room room) {
            Context.Rooms.Remove(room);

            int Result = Context.SaveChanges();

            return Result > 0;
        }

        public bool CreateRoom(Room room) {
            Context.Add(room);

            int Result = Context.SaveChanges();

            return Result > 0;
        }
    }
}
