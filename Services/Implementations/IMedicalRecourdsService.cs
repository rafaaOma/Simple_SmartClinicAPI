using SmartClinicAPI.Models;
public interface IMedicalRecourdsService
{//interface for medical recourds service
    List<MedicalRecourds> GetAllMedicalRecords();
    MedicalRecourds? CreateMedicalRecord(MedicalRecourds medicalRecourds);
}