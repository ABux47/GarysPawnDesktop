namespace GarysPawnDesktop.Helpers;

public static class RegisterFileSaver
{
    public static async Task SaveEndOfDayAsync(string content)
    {
        // …Documents\EndOfDay\YYYY-MM
        string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string monthDir = DateTime.Now.ToString("yyyy-MM");
        string targetDir = Path.Combine(docs, "EndOfDay", monthDir);

        Directory.CreateDirectory(targetDir);

        // File name with date + time so every save is unique
        string fileName = $"EndOfDay_{DateTime.Now:yyyy-MM-dd_HHmmss}.txt";
        string fullPath = Path.Combine(targetDir, fileName);

        await File.WriteAllTextAsync(fullPath, content);

#if WINDOWS
        // Highlight file in Explorer for quick confirmation (optional)
        System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{fullPath}\"");
#endif
    }
}
