using RegistrarManagement.Models;

namespace RegistrarManagement.Services;

public class ClearanceService
{
    private readonly FirebaseService _firebase = new();

    // ==========================================
    // TEAM 4 - STUDENT CLEARANCE RECORDS
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
    // This assumes the Library Team will save:
    //
    // library_clearances
    //    studentId
    //       LibraryStatus
    //
    // We can adjust this later if their actual
    // Firebase structure is different.
    // ==========================================

    public Task<LibraryClearance?> GetLibraryAsync(
        string studentId)
    {
        return _firebase.GetByIdAsync<LibraryClearance>(
            "library_clearances",
            studentId);
    }


    // ==========================================
    // MEDICAL STATUS
    // ==========================================
    // Your medical Firebase records are not
    // directly keyed using StudentId.
    //
    // Example:
    //
    // medical
    //    MR-0003
    //       StudentId = 26-00001
    //
    // So we get all medical records and search
    // for the matching StudentId.
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
    // ACCOUNTING / TUITION BALANCE
    // ==========================================
    // Gets the student's balance from:
    //
    // enrollments
    //    StudentId
    //    TuitionFee
    //       Balance
    //
    // null = No enrollment / tuition record
    // 0    = Cleared
    // > 0  = Not Cleared
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
                .OrderByDescending(x => x.SchoolYear)
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
    // COMPUTE ACCOUNTING STATUS
    // ==========================================

    public async Task<string> GetAccountingStatusAsync(
        string studentId)
    {
        decimal? balance =
            await GetStudentBalanceAsync(studentId);

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
    // OVERALL CLEARANCE STATUS
    // ==========================================
    //
    // Uses only:
    // 1. Library
    // 2. Medical
    // 3. Registrar
    // 4. Accounting
    //
    // Guidance has been removed.
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

        // If any department explicitly says
        // Not Cleared, overall is Not Cleared.
        if (statuses.Any(status =>
                status.Equals(
                    "Not Cleared",
                    StringComparison.OrdinalIgnoreCase)))
        {
            return "Not Cleared";
        }

        // Missing data or no shared record yet
        // means clearance is still pending.
        if (statuses.Any(status =>
                string.IsNullOrWhiteSpace(status) ||
                status.Equals(
                    "Pending",
                    StringComparison.OrdinalIgnoreCase) ||
                status.Equals(
                    "No Record",
                    StringComparison.OrdinalIgnoreCase)))
        {
            return "Pending";
        }

        // All four departments must be Cleared.
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
    // INTERNAL ENROLLMENT DATA MODELS
    // Used only for reading shared enrollment
    // data for Accounting Status.
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