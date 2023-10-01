using AppointmentScheudling.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheudling.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        public IActionResult Index()
        {
            _appointmentService.GetDoctorList();
            return View();
        }
    }
}
