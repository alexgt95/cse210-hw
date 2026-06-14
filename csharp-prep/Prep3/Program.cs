using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}

/*
WHY NOT A DO WHILE? COULD I HAVE GUESS BE PART OF THE SCOPE?
 using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 5;
        int guess = -1;

        do
        {
            Console.Write("What is the magic number? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);
        } while (guess != magicNumber);
    }
}
*/