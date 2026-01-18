using System;

public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string promptText, string entryText, string date)
    {
        _promptText = promptText;
        _entryText = entryText;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }

    // Formats the entry for file storage (CSV style)
    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}