namespace RegistrarManagement.Helpers;

public static class ValidationHelper
{
    public static bool Required(params string?[] values)
    {
        return values.All(
            value => !string.IsNullOrWhiteSpace(value)
        );
    }
}