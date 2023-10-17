namespace AppointmentScheudling.Models.ViewModels
{
    public class DoctorVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        // alernate detail doctor
        public int postalcode { get; set; }
        public int phonenumber { get; set; }
    }
}
