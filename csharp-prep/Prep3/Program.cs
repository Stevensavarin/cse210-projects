using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        Console.WriteLine();

        int magicNumberInt = int.Parse(magicNumber);

        int userGuess;

        do
        {
            Console.Write("What is your guess? ");
            string valueFromIUser = Console.ReadLine();
            userGuess = int.Parse(valueFromIUser);

            if (userGuess > magicNumberInt)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumberInt)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (userGuess != magicNumberInt);
    }
}