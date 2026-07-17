using RegistrarManagement.Models;
namespace RegistrarManagement.Services;
public class RegistrationService
{
    private readonly FirebaseService _firebase=new();
    public async Task<List<StudentRegistration>> GetAllAsync()=> (await _firebase.GetAllAsync<StudentRegistration>("student_registrations")).Values.ToList();
    public Task<bool> SaveAsync(StudentRegistration item)=>_firebase.PutAsync("student_registrations",item.RegistrationId,item);
    public Task<bool> DeleteAsync(string id)=>_firebase.DeleteAsync("student_registrations",id);
}
