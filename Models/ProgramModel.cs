using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class ProgramModel
{
    [JsonPropertyName("ProgramId")]
    public string ProgramId { get; set; } = string.Empty;

    [JsonPropertyName("ProgramName")]
    public string ProgramName { get; set; } = string.Empty;

    [JsonPropertyName("CollegeId")]
    public string CollegeId { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{ProgramId} - {ProgramName}";
    }
}