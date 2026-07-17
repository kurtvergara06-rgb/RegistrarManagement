using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class Subject
{
    [JsonPropertyName("subjectId")] public string SubjectId { get; set; } = string.Empty;
    [JsonPropertyName("subjectCode")] public string SubjectCode { get; set; } = string.Empty;
    [JsonPropertyName("subjectName")] public string SubjectName { get; set; } = string.Empty;
    [JsonPropertyName("units")] public int Units { get; set; }
    [JsonPropertyName("programId")] public string ProgramId { get; set; } = string.Empty;
    [JsonPropertyName("yearLevel")] public string YearLevel { get; set; } = string.Empty;
    [JsonPropertyName("semester")] public string Semester { get; set; } = string.Empty;
    [JsonPropertyName("status")] public string Status { get; set; } = string.Empty;
    public override string ToString() => $"{SubjectCode} - {SubjectName}";
}
