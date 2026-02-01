using System;

// CREATIVITY DISCLOSURE:
// 1. Added a session counter that tracks how many activities were completed in one sitting.
// 2. Implemented "No-Repeat" logic in ReflectionActivity so questions don't repeat until the list is exhausted.
// 3. Clean UI handling with clear console transitions.

class Program
{
    static void Main(string[] args)
    {
        int sessionCount = 0;
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine($"Activities completed this session: {sessionCount}");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    sessionCount++;
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    sessionCount++;
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    sessionCount++;
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}