using Microsoft.AspNetCore.Mvc;
using SmartClinicAPI.Models;

namespace SmartClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
          public AppointmentController(IAppointmentService appointmentService)
        {
        _appointmentService = appointmentService;
        }
        [HttpGet]
        public IActionResult GetAllAppointments()
        {
            var appointments = _appointmentService.GetAllAppointments();
            return Ok(appointments);    
        }
        [HttpPost]
        public IActionResult CreateAppointment([FromBody] Models.Appointment appointment)
        {
            _appointmentService.CreateAppointment(appointment);
            return CreatedAtAction(nameof(GetAllAppointments), new { id = appointment.AppointmentId }, appointment);//------
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAppointment(int id, [FromBody] Appointment appointment)
        {
            _appointmentService.UpdateAppointment(id, appointment);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAppointment(int id)
        {
            _appointmentService.DeleteAppointment(id);
            return NoContent();
        }
    }
}
