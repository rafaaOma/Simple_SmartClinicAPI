using Microsoft.AspNetCore.Mvc;


namespace SmartClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordsController : ControllerBase
    {
        private readonly IMedicalRecourdsService _medicalRecourdsService; //medical recourds interface dependency
        public MedicalRecordsController(IMedicalRecourdsService medicalRecourdsService)//constructor to initialize medical recourds service dependency
        {
            _medicalRecourdsService = medicalRecourdsService;
        }
        [HttpGet]
        public IActionResult GetAllMedicalRecords()//get all medical recourds
        {
            var records = _medicalRecourdsService.GetAllMedicalRecords();
            return Ok(records);
        }
        [HttpPost]
        public IActionResult CreateMedicalRecord([FromBody] Models.MedicalRecourds record) //post new medical recourd
        {
            var createdRecord = _medicalRecourdsService.CreateMedicalRecord(record);
            return CreatedAtAction(nameof(GetAllMedicalRecords), new { id = createdRecord?.RecordId }, createdRecord);
        }
    }
}
