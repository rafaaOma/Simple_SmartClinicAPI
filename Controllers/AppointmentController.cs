using Microsoft.AspNetCore.Mvc;
using SmartClinicAPI.Models;

namespace SmartClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;//appointment service dependency
          public AppointmentController(IAppointmentService appointmentService)
        {
        _appointmentService = appointmentService;
        }
        [HttpGet]
        public IActionResult GetAllAppointments() //get all appointments
        {
            var appointments = _appointmentService.GetAllAppointments();
            return Ok(appointments);    
        }
        [HttpPost]
        public IActionResult CreateAppointment([FromBody] Models.Appointment appointment) //post new appointment
        {
            _appointmentService.CreateAppointment(appointment);
            return CreatedAtAction(nameof(GetAllAppointments), new { id = appointment.AppointmentId }, appointment);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAppointment(int id, [FromBody] Appointment appointment) //update appointment by id
        {
            _appointmentService.UpdateAppointment(id, appointment);
            return NoContent();
        }
        [HttpDelete("{id}")] //delete specific appointment by id
        public IActionResult DeleteAppointment(int id)
        {
            _appointmentService.DeleteAppointment(id);
            return NoContent();
        }
    }
}
