using SmartClinicAPI.Models;
public class AppointmentService : IAppointmentService
{
    private static List<Appointment> _appointment = new()//list of appointments
    {
        new Appointment { AppointmentId = 1, Id = 111, AppointmentDate = DateTime.Now.AddDays(1), Description = "General Checkup" },
        new Appointment { AppointmentId = 2, Id = 211, AppointmentDate = DateTime.Now.AddDays(2), Description = "Dental Cleaning" }
    };

    public List<Appointment> GetAllAppointments()
    {
        return _appointment;//returns appointment list
    }
    public Appointment? CreateAppointment(Appointment appointment)
    {
        _appointment.Add(appointment);//adds new appointment to the list
        return appointment;
    }
    public void UpdateAppointment(int id, Appointment appointment)
    {
        var existingAppointment = _appointment.FirstOrDefault(a => a.AppointmentId == id);//first element match id or defult null
        if (existingAppointment != null)
        {
            
            existingAppointment.AppointmentDate = appointment.AppointmentDate;//update appointment date 
            existingAppointment.Description = appointment.Description;//update description
        }
    }
   public bool DeleteAppointment(int id)
    {
        var appointment = _appointment.FirstOrDefault(a => a.AppointmentId == id);
        if (appointment != null)
        {
            _appointment.Remove(appointment);//remove appointment from the list
            return true;
        }
        return false;
    }
}