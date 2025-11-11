using Microsoft.AspNetCore.Mvc;

namespace SmartClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllAppointments()
        {
            return Ok("Message");
        }
        [HttpPost]
        public IActionResult CreateAppointment([FromBody] object appointment)
        {
            return Ok("Message");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAppointment(int id, [FromBody] object appointment)
        {
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAppointment(int id)
        {
            return NoContent();
        }
    }
}
