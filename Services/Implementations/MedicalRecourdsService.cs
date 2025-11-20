using SmartClinicAPI.Models;
public class MedicalRecourdsService : IMedicalRecourdsService
{
    private readonly List<MedicalRecourds> _recourds = new() //list of recourds
    {
        new MedicalRecourds { RecordId = 1, PatientId = 101, VisitDate = DateTime.Now.AddDays(-10), Diagnosis = "Flu", Treatment = "Rest and hydration" },
        new MedicalRecourds { RecordId = 2, PatientId = 102, VisitDate = DateTime.Now.AddDays(-5), Diagnosis = "Sprained Ankle", Treatment = "Ice and elevation" }
    };
    public List<MedicalRecourds> GetAllMedicalRecords()
    {
        return _recourds;//returns recourds list
    }
    public MedicalRecourds? CreateMedicalRecord(MedicalRecourds medicalRecourds)
    {
        _recourds.Add(medicalRecourds);//adds new recourd to the list
        return medicalRecourds;
    }

} 