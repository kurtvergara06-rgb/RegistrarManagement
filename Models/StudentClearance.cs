using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class StudentClearance
{
    [JsonPropertyName("clearanceId")] public string ClearanceId { get; set; } = string.Empty;
    [JsonPropertyName("studentId")] public string StudentId { get; set; } = string.Empty;
    [JsonPropertyName("libraryStatus")] public string LibraryStatus { get; set; } = string.Empty;
    [JsonPropertyName("medicalStatus")] public string MedicalStatus { get; set; } = string.Empty;
    [JsonPropertyName("registrarStatus")] public string RegistrarStatus { get; set; } = string.Empty;
    [JsonPropertyName("accountingStatus")] public string AccountingStatus { get; set; } = string.Empty;
    [JsonPropertyName("guidanceStatus")] public string GuidanceStatus { get; set; } = string.Empty;
    [JsonPropertyName("overallStatus")] public string OverallStatus { get; set; } = string.Empty;
    [JsonPropertyName("remarks")] public string Remarks { get; set; } = string.Empty;
    [JsonPropertyName("updatedAt")] public string UpdatedAt { get; set; } = string.Empty;
}
