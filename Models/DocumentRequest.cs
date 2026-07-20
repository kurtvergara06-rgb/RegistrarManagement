using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class DocumentRequest
{
    [JsonPropertyName("requestId")] public string RequestId { get; set; } = "";
    [JsonPropertyName("studentId")] public string StudentId { get; set; } = "";
    [JsonPropertyName("documentType")] public string DocumentType { get; set; } = "";
    [JsonPropertyName("purpose")] public string Purpose { get; set; } = "";
    [JsonPropertyName("requestDate")] public string RequestDate { get; set; } = "";
    [JsonPropertyName("status")] public string Status { get; set; } = "";
    [JsonPropertyName("releaseDate")] public string ReleaseDate { get; set; } = "";
    [JsonPropertyName("remarks")] public string Remarks { get; set; } = "";
}
