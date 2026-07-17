using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using RegistrarManagement.Helpers;

namespace RegistrarManagement.Services;

public class FirebaseService
{
    private static readonly HttpClient Client = new();
    private readonly JsonSerializerOptions _options = new() { PropertyNameCaseInsensitive = true, WriteIndented = true };

    private static string BuildUrl(string node, string? id = null)
    {
        string baseUrl = FirebaseConfig.BaseUrl.TrimEnd('/');
        string path = string.IsNullOrWhiteSpace(id) ? node : $"{node}/{id}";
        return $"{baseUrl}/{path}.json?auth={Uri.EscapeDataString(FirebaseConfig.AuthSecret)}";
    }

    public async Task<Dictionary<string,T>> GetAllAsync<T>(string node)
    {
        using var response = await Client.GetAsync(BuildUrl(node));
        string body = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode) throw new InvalidOperationException($"Firebase read failed: {(int)response.StatusCode} {body}");
        if (string.IsNullOrWhiteSpace(body) || body == "null") return new();
        return JsonSerializer.Deserialize<Dictionary<string,T>>(body,_options) ?? new();
    }

    public async Task<T?> GetByIdAsync<T>(string node,string id)
    {
        using var response = await Client.GetAsync(BuildUrl(node,id));
        string body = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode) throw new InvalidOperationException($"Firebase read failed: {(int)response.StatusCode} {body}");
        if (string.IsNullOrWhiteSpace(body) || body == "null") return default;
        return JsonSerializer.Deserialize<T>(body,_options);
    }

    public async Task<bool> PutAsync<T>(string node,string id,T data)
    {
        string json=JsonSerializer.Serialize(data,_options);
        using var response=await Client.PutAsync(BuildUrl(node,id),new StringContent(json,Encoding.UTF8,"application/json"));
        if (!response.IsSuccessStatusCode) throw new InvalidOperationException($"Firebase save failed: {(int)response.StatusCode} {await response.Content.ReadAsStringAsync()}");
        return true;
    }

    public async Task<bool> DeleteAsync(string node,string id)
    {
        using var response=await Client.DeleteAsync(BuildUrl(node,id));
        if (!response.IsSuccessStatusCode) throw new InvalidOperationException($"Firebase delete failed: {(int)response.StatusCode} {await response.Content.ReadAsStringAsync()}");
        return true;
    }
}
