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
    public string OfferingId { get; set; } = "";

    [JsonPropertyName("SchoolYear")]
    public string SchoolYear { get; set; } = "";

    [JsonPropertyName("Semester")]
    public string Semester { get; set; } = "";

    [JsonPropertyName("Status")]
    public string Status { get; set; } = "";

    [JsonPropertyName("SubjectCode")]
    public string SubjectCode { get; set; } = "";
}