using Microsoft.AspNetCore.Mvc;


namespace SmartClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordsController : ControllerBase
    {
        private readonly IMedicalRecourdsService _medicalRecourdsService;
        public MedicalRecordsController(IMedicalRecourdsService medicalRecourdsService)//-----
        {
            _medicalRecourdsService = medicalRecourdsService;
        }
        [HttpGet]
        public IActionResult GetAllMedicalRecords()
        {
            var records = _medicalRecourdsService.GetAllMedicalRecords();
            return Ok(records);
        }
        [HttpPost]
        public IActionResult CreateMedicalRecord([FromBody] Models.MedicalRecourds record)
        {
            var createdRecord = _medicalRecourdsService.CreateMedicalRecord(record);
            return CreatedAtAction(nameof(GetAllMedicalRecords), new { id = createdRecord?.RecordId }, createdRecord);
        }
    }
}
