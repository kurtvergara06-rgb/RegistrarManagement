using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class Subject
{
    [JsonPropertyName("subjectId")] public string SubjectId { get; set; } = "";
    [JsonPropertyName("subjectCode")] public string SubjectCode { get; set; } = "";
    [JsonPropertyName("subjectName")] public string SubjectName { get; set; } = "";
    [JsonPropertyName("units")] public int Units { get; set; }
    [JsonPropertyName("programId")] public string ProgramId { get; set; } = "";
    [JsonPropertyName("yearLevel")] public string YearLevel { get; set; } = "";
    [JsonPropertyName("semester")] public string Semester { get; set; } = "";
    [JsonPropertyName("status")] public string Status { get; set; } = "";
    public override string ToString() => $"{SubjectCode} - {SubjectName}";
}
