using SmartClinicAPI.Models;
public class MedicalRecourdsService : IMedicalRecourdsService
{
    private readonly List<MedicalRecourds> _recourds = new()
    {
        new MedicalRecourds { RecordId = 1, PatientId = 101, VisitDate = DateTime.Now.AddDays(-10), Diagnosis = "Flu", Treatment = "Rest and hydration" },
        new MedicalRecourds { RecordId = 2, PatientId = 102, VisitDate = DateTime.Now.AddDays(-5), Diagnosis = "Sprained Ankle", Treatment = "Ice and elevation" }
    };
    public List<MedicalRecourds> GetAllMedicalRecords()
    {
        return _recourds;
    }
    public MedicalRecourds? CreateMedicalRecord(MedicalRecourds medicalRecourds)
    {
        _recourds.Add(medicalRecourds);
        return medicalRecourds;
    }

} 