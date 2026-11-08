// Exceeding requirements:
// Random prompts and questions in the Reflecting and Listing activities are not
// repeated until every one of them has been used at least once in the session.
// Each activity keeps a copy of its list and removes an item after showing it;
// when the copy is empty, it is refilled from the original list.
// The activity objects are created once in Main, so this works across the whole
// session, not just within a single activity run.

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathing.Run();
            }
            else if (choice == "2")
            {
                reflecting.Run();
            }
            else if (choice == "3")
            {
                listing.Run();
            }
        }
    }
}