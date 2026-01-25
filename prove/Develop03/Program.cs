using System;

// Exceeding Requirements:
// 1. Scripture Library: Added a ScriptureLibrary class to store multiple scriptures internally.
// 2. Random Selection: The program selects a random scripture from the library at startup.
// 3. Smart Hiding: The HideRandomWords method ensures it only picks words that are not already hidden.
// 4. Underscore Matching: The hidden words are replaced by underscores that match the length of the original word.

class Program
{
    static void Main(string[] args)
    {
        // 1. Initialize the internal library
        ScriptureLibrary library = new ScriptureLibrary();
        
        // 2. Get a random scripture from our stored list
        Scripture scripture = library.GetRandomScripture();

        string input = "";

        // 3. Main Loop
        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                // Hide 3 words at a time
                scripture.HideRandomWords(3);
            }
        }

        // Final view
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nExcellent work! You've hidden all the words.");
    }
}