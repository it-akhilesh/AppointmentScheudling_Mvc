using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheudling.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
