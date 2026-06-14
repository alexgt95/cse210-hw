using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userFullName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int squaredValue = SquareNumber(favoriteNumber);

        int yearOfBirth;
        PromptUserBirthYear(out yearOfBirth);


        DisplayResult(userFullName, squaredValue, yearOfBirth);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int enteredNumber = int.Parse(Console.ReadLine());

        return enteredNumber;
    }
    
    static void PromptUserBirthYear(out int yearOfBirth)
    {
        Console.Write($"Please enter the year you were born: ");
        yearOfBirth = int.Parse(Console.ReadLine());

    }

    static int SquareNumber(int number)
    {
        int squaredResult = number * number;
        return squaredResult;
    }

    static void DisplayResult(string userName, int squaredValue, int yearOfBirth)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredValue}.");
        Console.WriteLine($"{userName}, you will turn {2025 - yearOfBirth} years old this year.");
    }
}