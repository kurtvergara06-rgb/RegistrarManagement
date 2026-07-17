using RegistrarManagement.Models;
namespace RegistrarManagement.Services;
public class DocumentRequestService
{
    private readonly FirebaseService _firebase=new();
    public async Task<List<DocumentRequest>> GetAllAsync()=> (await _firebase.GetAllAsync<DocumentRequest>("document_requests")).Values.ToList();
    public Task<bool> SaveAsync(DocumentRequest item)=>_firebase.PutAsync("document_requests",item.RequestId,item);
    public Task<bool> DeleteAsync(string id)=>_firebase.DeleteAsync("document_requests",id);
}
