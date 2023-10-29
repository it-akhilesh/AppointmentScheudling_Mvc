using Microsoft.AspNetCore.Identity;

namespace AppointmentScheudling.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        // trail; 
        public string PatientDetail { get; set; }
        public int PostalCode { get; set; }

    }
}
