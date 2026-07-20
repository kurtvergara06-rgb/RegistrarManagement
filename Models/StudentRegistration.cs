using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class StudentRegistration
{
    [JsonPropertyName("registrationId")] public string RegistrationId { get; set; } = "";
    [JsonPropertyName("studentId")] public string StudentId { get; set; } = "";
    [JsonPropertyName("schoolYear")] public string SchoolYear { get; set; } = "";
    [JsonPropertyName("semester")] public string Semester { get; set; } = "";
    [JsonPropertyName("programId")] public string ProgramId { get; set; } = "";
    [JsonPropertyName("yearLevel")] public string YearLevel { get; set; } = "";
    [JsonPropertyName("registrationDate")] public string RegistrationDate { get; set; } = "";
    [JsonPropertyName("registrationStatus")] public string RegistrationStatus { get; set; } = "";
    [JsonPropertyName("remarks")] public string Remarks { get; set; } = "";
}
