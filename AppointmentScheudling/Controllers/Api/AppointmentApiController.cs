using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheudling.Controllers.Api
{
    public class AppointmentApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
