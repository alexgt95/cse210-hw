using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        FileManager fileManager = new FileManager();

        // Create a new entry using a random prompt
        Entry e1 = new Entry();
        e1._date = "2026-06-18";
        e1._promptText = generator.GetRandomPrompt();
        e1._entryText = "It was a great day overall.";

        journal.AddEntry(e1);
        journal.DisplayAll();

        // Save to file
        fileManager.SaveToFile("journal.txt", journal.GetEntries());

        // Clear and reload from file
        journal.ClearJournal();
        journal.SetEntries(fileManager.LoadFromFile("journal.txt"));

        journal.DisplayAll();
    }
}