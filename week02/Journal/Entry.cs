using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    // Constructor
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Display the entry
    public void Display()
    {
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Prompt: " + _prompt);
        Console.WriteLine("Response: " + _response);
        Console.WriteLine(new string('-', 40));
    }

    // Convert entry to string for saving
    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    // Create Entry from a file line
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length < 3) return null;
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
