using RegistrarManagement.Models;

namespace RegistrarManagement.Services;

public class StudentService
{
    private readonly FirebaseService _firebase = new();

    public async Task<List<Student>> GetAllAsync()
    {
        Dictionary<string, Student> result =
            await _firebase.GetAllAsync<Student>("students");

        return result.Values
            .Where(student =>
                student.Status.Equals(
                    "Active",
                    StringComparison.OrdinalIgnoreCase
                )
            )
            .OrderBy(student => student.LastName)
            .ThenBy(student => student.FirstName)
            .ToList();
    }
}