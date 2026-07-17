using RegistrarManagement.Models;
namespace RegistrarManagement.Services;
public class ClearanceService
{
    private readonly FirebaseService _firebase=new();
    public async Task<List<StudentClearance>> GetAllAsync()=> (await _firebase.GetAllAsync<StudentClearance>("student_clearances")).Values.ToList();
    public Task<LibraryClearance?> GetLibraryAsync(string studentId)=>_firebase.GetByIdAsync<LibraryClearance>("library_clearances",studentId);
    public Task<MedicalClearance?> GetMedicalAsync(string studentId)=>_firebase.GetByIdAsync<MedicalClearance>("medical_clearances",studentId);
    public Task<bool> SaveAsync(StudentClearance item)=>_firebase.PutAsync("student_clearances",item.ClearanceId,item);
    public Task<bool> DeleteAsync(string id)=>_firebase.DeleteAsync("student_clearances",id);
    public static string Overall(StudentClearance x)=> new[]{x.LibraryStatus,x.MedicalStatus,x.RegistrarStatus,x.AccountingStatus,x.GuidanceStatus}.All(s=>s.Equals("Cleared",StringComparison.OrdinalIgnoreCase))?"Cleared":"Pending";
}
