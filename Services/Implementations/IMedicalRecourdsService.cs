using SmartClinicAPI.Models;
public interface IMedicalRecourdsService
{
    List<MedicalRecourds> GetAllMedicalRecords();
    MedicalRecourds? CreateMedicalRecord(MedicalRecourds medicalRecourds);
}