using System;

class Program
{
    static void Main(string[] args)
    {

        // Get a random number
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        Console.WriteLine($"Guess the magic number");

        int userGuess;

        do
        {
            Console.Write("What is your guess? ");
            string valueFromIUser = Console.ReadLine();
            userGuess = int.Parse(valueFromIUser);

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (userGuess != magicNumber);
    }
}