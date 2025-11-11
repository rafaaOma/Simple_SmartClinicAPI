using Microsoft.AspNetCore.Mvc;
namespace SmartClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllMedicalRecords()
        {
            return Ok("Message");
        }
        [HttpPost]
        public IActionResult CreateMedicalRecord([FromBody] object record)
        {
            return Ok("Message");
        }
    }
}
