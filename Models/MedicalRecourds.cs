namespace SmartClinicAPI.Models{
    public class MedicalRecourds
    {
        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public string Diagnosis { get; set; } = string.Empty;
        public string Treatment { get; set; } = string.Empty;
    }
}