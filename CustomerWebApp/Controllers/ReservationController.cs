using System;
using System.Collections.Generic;
using System.Linq;
using CustomerWebApp.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly ILogger<ReservationController> _logger;
        private readonly DatabaseContext db;

        public ReservationController(ILogger<ReservationController> logger, DatabaseContext context)
        {
            db = context;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IEnumerable<Room> Get(int id)
        {
            // Get all reservations with this userid find all rooms in reservations
            List<int?> res = db.Reservations.ToList().Where(r => r.Usernr == id).Select(r => r.Roomnr).ToList();
            return db.Rooms.ToList().Where(r => res.Contains(r.Roomnr)).ToList();
        }

        [HttpPost]
        public void Post(Reservation reservation)
        {
            // Get all rooms, make this room Avaliable = false
            Room r = db.Rooms.ToList().Where(r => r.Roomnr == reservation.Roomnr).First();
            r.Available = false;
            db.Rooms.Update(r);
            db.SaveChanges();
            Reservation res = new Reservation { Roomnr = reservation.Roomnr, Usernr = reservation.Usernr };
            db.Reservations.Add(res);
            db.SaveChanges();
        }
    }
}
