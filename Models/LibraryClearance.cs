using System.Text.Json.Serialization;

namespace RegistrarManagement.Models;

public class LibraryClearance
{
    [JsonPropertyName("Status")]
    public string LibraryStatus { get; set; } = string.Empty;

    [JsonPropertyName("LastChecked")]
    public string LastChecked { get; set; } = string.Empty;
}