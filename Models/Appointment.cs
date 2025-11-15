namespace SmartClinicAPI.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; } //appointment ID
        public int Id { get; set; } //ID of the user who made the appointment
        public DateTime AppointmentDate { get; set; }
        public string Description { get; set; } = String.Empty;
    }
}