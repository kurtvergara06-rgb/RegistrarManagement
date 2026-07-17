namespace RegistrarManagement.Helpers;

public static class FirebaseConfig
{
    public static string BaseUrl { get; private set; } = string.Empty;
    public static string AuthSecret { get; private set; } = string.Empty;

    public static void Load()
    {
        string envPath = Path.Combine(AppContext.BaseDirectory, "firebase.env");
        if (!File.Exists(envPath))
        {
            string projectPath = Path.Combine(Directory.GetCurrentDirectory(), "firebase.env");
            envPath = File.Exists(projectPath) ? projectPath : envPath;
        }

        if (!File.Exists(envPath))
            throw new FileNotFoundException("firebase.env was not found.");

        foreach (string rawLine in File.ReadAllLines(envPath))
        {
            string line = rawLine.Trim();
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
            int separator = line.IndexOf('=');
            if (separator <= 0) continue;
            string key = line[..separator].Trim();
            string value = line[(separator + 1)..].Trim();
            if (key == "FIREBASE_URL") BaseUrl = value;
            if (key == "FIREBASE_SECRET") AuthSecret = value;
        }

        if (string.IsNullOrWhiteSpace(BaseUrl))
            throw new InvalidOperationException("FIREBASE_URL is missing from firebase.env.");
        if (string.IsNullOrWhiteSpace(AuthSecret))
            throw new InvalidOperationException("FIREBASE_SECRET is missing from firebase.env.");
    }
}
