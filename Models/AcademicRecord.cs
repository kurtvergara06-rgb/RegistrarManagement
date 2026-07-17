using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class AcademicRecord
{
    [JsonPropertyName("recordId")] public string RecordId { get; set; } = string.Empty;
    [JsonPropertyName("studentId")] public string StudentId { get; set; } = string.Empty;
    [JsonPropertyName("schoolYear")] public string SchoolYear { get; set; } = string.Empty;
    [JsonPropertyName("semester")] public string Semester { get; set; } = string.Empty;
    [JsonPropertyName("programId")] public string ProgramId { get; set; } = string.Empty;
    [JsonPropertyName("yearLevel")] public string YearLevel { get; set; } = string.Empty;
    [JsonPropertyName("academicStatus")] public string AcademicStatus { get; set; } = string.Empty;
    [JsonPropertyName("remarks")] public string Remarks { get; set; } = string.Empty;
}
