namespace RegistrarManagement.Models;

public class StudentClearance
{
    public string ClearanceId { get; set; } = "";

    public string StudentId { get; set; } = "";

    public string LibraryStatus { get; set; } = "";

    public string MedicalStatus { get; set; } = "";

    public string RegistrarStatus { get; set; } = "";

    public string AccountingStatus { get; set; } = "";

    public string OverallStatus { get; set; } = "";

    public string Remarks { get; set; } = "";

    public string UpdatedAt { get; set; } = "";
}