using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class MedicalClearance
{
    [JsonPropertyName("StudentId")]
    public string StudentId { get; set; } = "";

    [JsonPropertyName("Status")]
    public string MedicalStatus { get; set; } = "";

    [JsonPropertyName("Remarks")]
    public string Remarks { get; set; } = "";

    [JsonPropertyName("Purpose")]
    public string Purpose { get; set; } = "";

    [JsonPropertyName("Date")]
    public string Date { get; set; } = "";
}