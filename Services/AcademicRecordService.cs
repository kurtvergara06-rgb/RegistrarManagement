using RegistrarManagement.Models;
namespace RegistrarManagement.Services;
public class AcademicRecordService
{
    private readonly FirebaseService _firebase=new();
    public async Task<List<AcademicRecord>> GetAllAsync()=> (await _firebase.GetAllAsync<AcademicRecord>("academic_records")).Values.ToList();
    public Task<bool> SaveAsync(AcademicRecord item)=>_firebase.PutAsync("academic_records",item.RecordId,item);
    public Task<bool> DeleteAsync(string id)=>_firebase.DeleteAsync("academic_records",id);
}
