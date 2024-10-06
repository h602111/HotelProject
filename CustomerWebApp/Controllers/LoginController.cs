using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerWebApp.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustomerWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly DatabaseContext db;
        private int usernr = 1;

        public LoginController(ILogger<LoginController> logger, DatabaseContext context)
        {
            db = context;
            _logger = logger;
        }

        [HttpPost]
        public User Post(User user)
        {
            List<User> ul = db.Users.ToList().Where(u => u.Email == user.Email).ToList();
            if (ul.Count == 0)
            {
                User u = new User { Usernr = usernr++, Email = user.Email, Password = user.Password };
                db.Users.Add(u);
                db.SaveChanges();
                return u;
            }
            else
            {
                return ul.First();
            }
        }

    }
}
