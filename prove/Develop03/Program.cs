using System;

class Program
{
    static void Main(string[] args)
    {
        Library myLibrary = new Library();

        myLibrary.AddScripture(new Reference("Alma", 32, 21), "This verse teaches about faith as not having a perfect knowledge but having hope for things which are not seen, which are true.");
        myLibrary.AddScripture(new Reference("Moroni", 10, 4), "This verse encourages individuals to ask God with a sincere heart and real intent to know the truth of all things.");
        myLibrary.AddScripture(new Reference("Doctrine and Covenants", 19, 23), "Here, the Lord invites us to learn of Him, listen to His words, and find peace in His teachings.");
        myLibrary.AddScripture(new Reference("Abraham", 3, 25), "This verse explains the purpose of life on earth as a test to see if we will do all things the Lord commands.");
        myLibrary.AddScripture(new Reference("Matthew", 5, 14), "A key verse from the Sermon on the Mount, it emphasizes the role of followers of Christ as the light of the world, meant to shine forth to others.");
        Scripture scripture = myLibrary.SelectRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

            if (scripture.IsCompletlyHidden())
            {
                break;
            }

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}