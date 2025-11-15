using SmartClinicAPI.Models;
public class AppointmentService : IAppointmentService
{
    private static List<Appointment> _appointment = new()
    {
        new Appointment { AppointmentId = 1, Id = 111, AppointmentDate = DateTime.Now.AddDays(1), Description = "General Checkup" },
        new Appointment { AppointmentId = 2, Id = 211, AppointmentDate = DateTime.Now.AddDays(2), Description = "Dental Cleaning" }
    };

    public List<Appointment> GetAllAppointments()
    {
        return _appointment;
    }
    public Appointment? CreateAppointment(Appointment appointment)
    {
        _appointment.Add(appointment);
        return appointment;
    }
    public void UpdateAppointment(int id, Appointment appointment)
    {
        var existingAppointment = _appointment.FirstOrDefault(a => a.AppointmentId == id);//----firstordefault
        if (existingAppointment != null)
        {
            existingAppointment.AppointmentId = appointment.AppointmentId;
            existingAppointment.AppointmentDate = appointment.AppointmentDate;
            existingAppointment.Description = appointment.Description;
        }
    }
   public bool DeleteAppointment(int id)
    {
        var appointment = _appointment.FirstOrDefault(a => a.AppointmentId == id);
        if (appointment != null)
        {
            _appointment.Remove(appointment);
            return true;
        }
        return false;
    }
}