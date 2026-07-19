namespace RegistrarManagement.Helpers;

public static class IdGenerator
{
    public static string CreateNext(
        string prefix,
        IEnumerable<string> existingIds)
    {
        string prefixWithDash = $"{prefix}-";

        int maxNumber = existingIds
            .Where(id =>
                !string.IsNullOrWhiteSpace(id) &&
                id.StartsWith(
                    prefixWithDash,
                    StringComparison.OrdinalIgnoreCase))
            .Select(id =>
            {
                string numberPart =
                    id.Substring(prefixWithDash.Length);

                return int.TryParse(
                    numberPart,
                    out int number)
                    ? number
                    : 0;
            })
            .DefaultIfEmpty(0)
            .Max();

        int nextNumber = maxNumber + 1;

        return $"{prefix}-{nextNumber:D4}";
    }
}