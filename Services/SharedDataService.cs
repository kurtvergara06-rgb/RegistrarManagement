using RegistrarManagement.Models;

namespace RegistrarManagement.Services;

public class SharedDataService
{
    private readonly FirebaseService _firebase = new();

    public async Task<List<ProgramModel>> GetProgramsAsync()
    {
        Dictionary<string, ProgramModel> result =
            await _firebase.GetAllAsync<ProgramModel>(
                "academicManagement/programs"
            );

        return result.Values
            .OrderBy(program => program.ProgramName)
            .ToList();
    }

    public async Task<List<Subject>> GetSubjectsAsync()
    {
        Dictionary<string, Subject> result =
            await _firebase.GetAllAsync<Subject>(
                "academicManagement/courses"
            );

        return result.Values
            .OrderBy(subject => subject.SubjectCode)
            .ToList();
    }

    public async Task<List<AcademicOffering>>
        GetAcademicOfferingsAsync()
    {
        Dictionary<string, AcademicOffering> result =
            await _firebase.GetAllAsync<AcademicOffering>(
                "academicManagement/academicofferings"
            );

        return result.Values
            .Where(offering =>
                offering.Status.Equals(
                    "Open",
                    StringComparison.OrdinalIgnoreCase
                )
            )
            .OrderByDescending(offering => offering.SchoolYear)
            .ThenBy(offering => offering.Semester)
            .ToList();
    }
}