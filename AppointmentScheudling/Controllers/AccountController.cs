using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheudling.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
