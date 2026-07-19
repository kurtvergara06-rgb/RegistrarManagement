using RegistrarManagement.Models;

namespace RegistrarManagement.Services;

public class ClearanceService
{
    private readonly FirebaseService _firebase = new();

    // ==========================================
    // GET ALL STUDENT CLEARANCE RECORDS
    // ==========================================

    public async Task<List<StudentClearance>> GetAllAsync()
    {
        var records =
            await _firebase.GetAllAsync<StudentClearance>(
                "student_clearances");

        return records.Values.ToList();
    }

    // ==========================================
    // LIBRARY STATUS
    // ==========================================

    public Task<LibraryClearance?> GetLibraryAsync(
    string studentId)
    {
        return _firebase.GetByIdAsync<LibraryClearance>(
            "library/clearanceStatuses",
            studentId);
    }

    // ==========================================
    // MEDICAL STATUS
    // Reads records from the "medical" node
    // and finds the matching StudentId.
    // ==========================================

    public async Task<MedicalClearance?> GetMedicalAsync(
        string studentId)
    {
        var records =
            await _firebase.GetAllAsync<MedicalClearance>(
                "medical");

        return records.Values
            .FirstOrDefault(x =>
                x.StudentId.Equals(
                    studentId,
                    StringComparison.OrdinalIgnoreCase));
    }

    // ==========================================
    // REGISTRAR STATUS
    // Automatically computed from
    // student_registrations.
    // ==========================================

    public async Task<string> GetRegistrarStatusAsync(
        string studentId)
    {
        var registrations =
            await _firebase.GetAllAsync<StudentRegistration>(
                "student_registrations");

        StudentRegistration? registration =
            registrations.Values
                .Where(x =>
                    x.StudentId.Equals(
                        studentId,
                        StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x =>
                    x.RegistrationDate)
                .FirstOrDefault();

        if (registration == null)
        {
            return "No Record";
        }

        return registration.RegistrationStatus switch
        {
            "Registered" => "Cleared",
            "Pending" => "Pending",
            "On Hold" => "Not Cleared",
            "Cancelled" => "Not Cleared",
            _ => "Pending"
        };
    }

    // ==========================================
    // STUDENT TUITION BALANCE
    // enrollments is stored as a JSON array.
    // ==========================================

    public async Task<decimal?> GetStudentBalanceAsync(
        string studentId)
    {
        var enrollments =
            await _firebase.GetListAsync<EnrollmentClearanceData>(
                "enrollments");

        EnrollmentClearanceData? enrollment =
            enrollments
                .Where(x =>
                    x.StudentId.Equals(
                        studentId,
                        StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x =>
                    x.SchoolYear)
                .FirstOrDefault();

        if (enrollment == null)
        {
            return null;
        }

        if (enrollment.TuitionFee == null)
        {
            return null;
        }

        return enrollment.TuitionFee.Balance;
    }

    // ==========================================
    // ACCOUNTING STATUS
    // ==========================================

    public async Task<string> GetAccountingStatusAsync(
        string studentId)
    {
        decimal? balance =
            await GetStudentBalanceAsync(
                studentId);

        if (balance == null)
        {
            return "No Record";
        }

        if (balance <= 0)
        {
            return "Cleared";
        }

        return "Not Cleared";
    }

    // ==========================================
    // SAVE
    // ==========================================

    public Task<bool> SaveAsync(
        StudentClearance item)
    {
        return _firebase.PutAsync(
            "student_clearances",
            item.ClearanceId,
            item);
    }

    // ==========================================
    // DELETE
    // ==========================================

    public Task<bool> DeleteAsync(
        string id)
    {
        return _firebase.DeleteAsync(
            "student_clearances",
            id);
    }

    // ==========================================
    // OVERALL STATUS
    // ==========================================

    public static string Overall(
        StudentClearance clearance)
    {
        string[] statuses =
        {
            clearance.LibraryStatus,
            clearance.MedicalStatus,
            clearance.RegistrarStatus,
            clearance.AccountingStatus
        };

        if (statuses.Any(status =>
                status.Equals(
                    "Not Cleared",
                    StringComparison.OrdinalIgnoreCase)))
        {
            return "Not Cleared";
        }

        if (statuses.Any(status =>
                string.IsNullOrWhiteSpace(status) ||
                status.Equals(
                    "Pending",
                    StringComparison.OrdinalIgnoreCase) ||
                status.Equals(
                    "No Record",
                    StringComparison.OrdinalIgnoreCase) ||
                status.Equals(
                    "Ongoing",
                    StringComparison.OrdinalIgnoreCase)))
        {
            return "Pending";
        }

        if (statuses.All(status =>
                status.Equals(
                    "Cleared",
                    StringComparison.OrdinalIgnoreCase)))
        {
            return "Cleared";
        }

        return "Pending";
    }

    // ==========================================
    // INTERNAL ENROLLMENT MODELS
    // ==========================================

    private class EnrollmentClearanceData
    {
        public string StudentId { get; set; } = "";

        public string SchoolYear { get; set; } = "";

        public string Semester { get; set; } = "";

        public string EnrollmentStatus { get; set; } = "";

        public TuitionFeeData? TuitionFee { get; set; }
    }

    private class TuitionFeeData
    {
        public decimal AmountPaid { get; set; }

        public decimal Balance { get; set; }

        public decimal Discount { get; set; }

        public decimal LabFees { get; set; }

        public decimal MiscFees { get; set; }

        public decimal TotalAssessment { get; set; }

        public decimal TuitionPerUnit { get; set; }
    }
}