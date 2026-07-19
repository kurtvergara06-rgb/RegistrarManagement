using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class MedicalClearance
{
    [JsonPropertyName("StudentId")]
    public string StudentId { get; set; } = string.Empty;

    [JsonPropertyName("Status")]
    public string MedicalStatus { get; set; } = string.Empty;

    [JsonPropertyName("Remarks")]
    public string Remarks { get; set; } = string.Empty;

    [JsonPropertyName("Purpose")]
    public string Purpose { get; set; } = string.Empty;

    [JsonPropertyName("Date")]
    public string Date { get; set; } = string.Empty;
}