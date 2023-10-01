﻿using AppointmentScheudling.Data;
using AppointmentScheudling.Models.ViewModels;
using AppointmentScheudling.Utility;

namespace AppointmentScheudling.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;
        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<DoctorVM> GetDoctorList()
        {
            var doctors = (from user in _db.Users
                           join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                           join roles in _db.Roles.Where(x=>x.Name==Helper.Doctor) on userRoles.RoleId equals roles.Id
                           select new DoctorVM
                           {
                               Id = user.Id,
                               Name = user.Name,
                           }).ToList();
            return doctors;
        }

        public List<PatientVM> GetPatientList()
        {
            throw new NotImplementedException();
        }
    }
}
