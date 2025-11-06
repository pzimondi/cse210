using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    // Helper to format entry for saving
    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    // Helper to load from file
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length < 3) return null;
        return new Entry
        {
            _date = parts[0],
            _promptText = parts[1],
            _entryText = parts[2]
        };
    }
}
