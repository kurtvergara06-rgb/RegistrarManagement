namespace RegistrarManagement.Helpers;
public static class IdGenerator
{
    public static string Create(string prefix) => $"{prefix}-{DateTime.Now:yyyyMMddHHmmssfff}";
}
