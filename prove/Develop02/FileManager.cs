using System;
using System.Collections.Generic;
using System.IO;

class FileManager
{
    public static void SaveToFile(List<Entry> entries)
    {
        Console.WriteLine("Saving to file...");
        string filename = "entries.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e._date}||{e._promp_text}||{e._entry_text}");
            }
        }
    }

    public static List<Entry> ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Entry> entries = new List<Entry>();
        string filename = "people.txt";

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promp_text = parts[1];
            newEntry._entry_text = parts[2];
            entries.Add(newEntry);
        }

        return entries;
    }
}