using SmartClinicAPI.Models;
public interface IAppointmentService
{//interface for appointment service
    List<Appointment> GetAllAppointments();
    Appointment? CreateAppointment(Appointment appointment);
    void UpdateAppointment(int id, Appointment appointment);
    bool DeleteAppointment(int id);
}