using System;
using System.Collections.Generic;
using System.Linq;

using HotelDataLibrary.Database;
using HotelDataLibrary.Models;

namespace HotelDataLibrary.Data {
    public class UsersClient {

        DatabaseContext Context;

        public UsersClient() {
            Context = new DatabaseContext();
        }

        public List<User> GetAllUsers() {
            return Context.Users.ToList();
        }

        public bool DeleteUser(User user) {
            Context.Users.Remove(user);

            int Result = Context.SaveChanges();

            return Result > 0;
        }

        public bool CreateUser(User user) {
            Context.Add(user);

            int Result = Context.SaveChanges();

            return Result > 0;
        }
    }
}
