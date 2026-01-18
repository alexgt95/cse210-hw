using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        Console.WriteLine("Welcome to the Daily Journal Program!");

        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Write a new entry
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("> ");
                        string response = Console.ReadLine();
                        string date = DateTime.Now.ToShortDateString();

                        Entry newEntry = new Entry(prompt, response, date);
                        theJournal.AddEntry(newEntry);
                        break;

                    case 2:
                        // Display the journal
                        Console.WriteLine("\n--- Journal Entries ---");
                        theJournal.DisplayAll();
                        break;

                    case 3:
                        // Load from file
                        Console.Write("What is the filename? ");
                        string loadFile = Console.ReadLine();
                        theJournal.LoadFromFile(loadFile);
                        break;

                    case 4:
                        // Save to file
                        Console.Write("What is the filename? ");
                        string saveFile = Console.ReadLine();
                        theJournal.SaveToFile(saveFile);
                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}