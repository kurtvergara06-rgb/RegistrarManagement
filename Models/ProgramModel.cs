using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class ProgramModel
{
    [JsonPropertyName("ProgramId")]
    public string ProgramId { get; set; } = "";

    [JsonPropertyName("ProgramName")]
    public string ProgramName { get; set; } = "";

    [JsonPropertyName("CollegeId")]
    public string CollegeId { get; set; } = "";

    public override string ToString()
    {
        return $"{ProgramId} - {ProgramName}";
    }
}