using Microsoft.AspNetCore.Identity;

namespace AppointmentScheudling.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public  int PostalCode { get; set; }
    }
}
