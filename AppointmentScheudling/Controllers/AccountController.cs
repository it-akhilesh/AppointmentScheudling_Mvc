using AppointmentScheudling.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheudling.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
