using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class LibraryClearance
{
    [JsonPropertyName("StudentId")]
    public string StudentId { get; set; } = "";

    [JsonPropertyName("Status")]
    public string LibraryStatus { get; set; } = "";

    [JsonPropertyName("LastChecked")]
    public string LastChecked { get; set; } = "";
}