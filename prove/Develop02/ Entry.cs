using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net.Http.Headers;

public class Entry
{
    public string _date;
    public string _promp_text;
    public string _entry_text;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("-------------------");
    }
}