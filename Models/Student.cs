using System.Text.Json.Serialization;
using RegistrarManagement.Helpers;

namespace RegistrarManagement.Models;

public class Student
{
    [JsonPropertyName("StudentId")]
    public string StudentId { get; set; } = string.Empty;

    [JsonPropertyName("FirstName")]
    public string FirstName { get; set; } = string.Empty;

    [JsonPropertyName("MiddleName")]
    public string MiddleName { get; set; } = string.Empty;

    [JsonPropertyName("LastName")]
    public string LastName { get; set; } = string.Empty;

    [JsonPropertyName("ProgramId")]
    public string ProgramId { get; set; } = string.Empty;

    [JsonPropertyName("CollegeId")]
    public string CollegeId { get; set; } = string.Empty;

    [JsonPropertyName("YearLevel")]
    [JsonConverter(typeof(StringOrNumberConverter))]
    public string YearLevel { get; set; } = string.Empty;

    [JsonPropertyName("Status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("Email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("ContactNumber")]
    public string ContactNumber { get; set; } = string.Empty;

    [JsonIgnore]
    public string FullName
    {
        get
        {
            return string.Join(
                " ",
                new[] { FirstName, MiddleName, LastName }
                    .Where(name => !string.IsNullOrWhiteSpace(name))
            );
        }
    }

    public override string ToString()
    {
        return $"{StudentId} - {FullName}";
    }
}