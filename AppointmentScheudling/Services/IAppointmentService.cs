using AppointmentScheudling.Models.ViewModels;

namespace AppointmentScheudling.Services
{
    public interface IAppointmentService
    {
        public List<DoctorVM> GetDoctorList();
        public List<PatientVM> GetPatientList();
        public Task<int> AddUpdate(AppointmentVM model);
    }
}
