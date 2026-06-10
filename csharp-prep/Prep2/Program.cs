using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage grade did you get? ");
        string userInput = Console.ReadLine();
        int percentageGrade = int.Parse(userInput);
        string letterGrade;

    if (percentageGrade < 0 || percentageGrade > 100)
        {
            letterGrade = "That is not a valid grade percentage";
        }
        else if (percentageGrade >= 90 && percentageGrade <= 100)
        {
            letterGrade = "A";
        }
        else if (percentageGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (percentageGrade >= 80)
        {
            letterGrade = "C";
        }
        else if (percentageGrade >= 80)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (percentageGrade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}