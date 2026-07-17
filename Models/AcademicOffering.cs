using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class AcademicOffering
{
    [JsonPropertyName("OfferingID")]
    public string OfferingId { get; set; } = string.Empty;

    [JsonPropertyName("SchoolYear")]
    public string SchoolYear { get; set; } = string.Empty;

    [JsonPropertyName("Semester")]
    public string Semester { get; set; } = string.Empty;

    [JsonPropertyName("Status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("SubjectCode")]
    public string SubjectCode { get; set; } = string.Empty;
}