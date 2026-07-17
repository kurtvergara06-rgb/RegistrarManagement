using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class StudentRegistration
{
    [JsonPropertyName("registrationId")] public string RegistrationId { get; set; } = string.Empty;
    [JsonPropertyName("studentId")] public string StudentId { get; set; } = string.Empty;
    [JsonPropertyName("schoolYear")] public string SchoolYear { get; set; } = string.Empty;
    [JsonPropertyName("semester")] public string Semester { get; set; } = string.Empty;
    [JsonPropertyName("programId")] public string ProgramId { get; set; } = string.Empty;
    [JsonPropertyName("yearLevel")] public string YearLevel { get; set; } = string.Empty;
    [JsonPropertyName("registrationDate")] public string RegistrationDate { get; set; } = string.Empty;
    [JsonPropertyName("registrationStatus")] public string RegistrationStatus { get; set; } = string.Empty;
    [JsonPropertyName("remarks")] public string Remarks { get; set; } = string.Empty;
}
