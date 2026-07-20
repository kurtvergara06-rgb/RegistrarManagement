using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class AcademicRecord
{
    [JsonPropertyName("recordId")] public string RecordId { get; set; } = "";
    [JsonPropertyName("studentId")] public string StudentId { get; set; } = "";
    [JsonPropertyName("schoolYear")] public string SchoolYear { get; set; } = "";
    [JsonPropertyName("semester")] public string Semester { get; set; } = "";
    [JsonPropertyName("programId")] public string ProgramId { get; set; } = "";
    [JsonPropertyName("yearLevel")] public string YearLevel { get; set; } = "";
    [JsonPropertyName("academicStatus")] public string AcademicStatus { get; set; } = "";
    [JsonPropertyName("remarks")] public string Remarks { get; set; } = "";
}
