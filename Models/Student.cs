using System.Text.Json.Serialization;
using RegistrarManagement.Helpers;

namespace RegistrarManagement.Models;

public class Student
{
    [JsonPropertyName("StudentId")]
    public string StudentId { get; set; } = "";

    [JsonPropertyName("FirstName")]
    public string FirstName { get; set; } = "";

    [JsonPropertyName("MiddleName")]
    public string MiddleName { get; set; } = "" ;

    [JsonPropertyName("LastName")]
    public string LastName { get; set; } = "";

    [JsonPropertyName("ProgramId")]
    public string ProgramId { get; set; } = "";

    [JsonPropertyName("CollegeId")]
    public string CollegeId { get; set; } = "";

    [JsonPropertyName("YearLevel")]
    [JsonConverter(typeof(StringOrNumberConverter))]
    public string YearLevel { get; set; } = "";

    [JsonPropertyName("Status")]
    public string Status { get; set; } = "";

    [JsonPropertyName("Email")]
    public string Email { get; set; } = "";

    [JsonPropertyName("ContactNumber")]
    public string ContactNumber { get; set; } = "";

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