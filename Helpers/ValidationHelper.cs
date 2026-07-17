namespace RegistrarManagement.Helpers;
public static class ValidationHelper
{
    public static bool Required(params string?[] values) => values.All(v => !string.IsNullOrWhiteSpace(v));
}
