using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class MedicalClearance
{
    [JsonPropertyName("studentId")] public string StudentId { get; set; } = string.Empty;
    [JsonPropertyName("medicalStatus")] public string MedicalStatus { get; set; } = string.Empty;
    [JsonPropertyName("remarks")] public string Remarks { get; set; } = string.Empty;
    [JsonPropertyName("updatedAt")] public string UpdatedAt { get; set; } = string.Empty;
}
