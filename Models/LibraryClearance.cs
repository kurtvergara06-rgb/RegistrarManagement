using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class LibraryClearance
{
    [JsonPropertyName("studentId")] public string StudentId { get; set; } = string.Empty;
    [JsonPropertyName("libraryStatus")] public string LibraryStatus { get; set; } = string.Empty;
    [JsonPropertyName("remarks")] public string Remarks { get; set; } = string.Empty;
    [JsonPropertyName("updatedAt")] public string UpdatedAt { get; set; } = string.Empty;
}
