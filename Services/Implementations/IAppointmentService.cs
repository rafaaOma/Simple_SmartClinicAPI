using SmartClinicAPI.Models;
public interface IAppointmentService
{
    List<Appointment> GetAllAppointments();
    Appointment? CreateAppointment(Appointment appointment);
    void UpdateAppointment(int id, Appointment appointment);
    bool DeleteAppointment(int id);
}