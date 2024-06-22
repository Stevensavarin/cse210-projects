using System;
using System.IO;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator myPrompt = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal App");

        int userSelection = -1;
        string userEntry = "";

        while (userSelection != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            try
            {
                Console.Write("What would you like to do? (Enter a number): ");
                string valueFromUser = Console.ReadLine();
                userSelection = int.Parse(valueFromUser);
                Console.WriteLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nThat's not a valid number.");
            }

            if (userSelection == 1)
            {
                string randomPrompt =  myPrompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);

                DateTime date = DateTime.Today;
                string formatedDate = date.ToString("dd-MM-yyyy");

                Console.Write("> ");
                userEntry = Console.ReadLine();

                Entry myEntry = new Entry();

                myEntry._date = formatedDate;
                myEntry._promptText = randomPrompt;
                myEntry._entryText = userEntry;

                myJournal.AddEntry(myEntry);
            }
            else if (userSelection == 2)
            {   
                myJournal.DisplayAll();
            }
            else if (userSelection == 3)
            {
                Console.WriteLine("Insert the filename");
                string fileName = Console.ReadLine();

                myJournal.LoadFromFile(fileName);
            }
            else if (userSelection == 4)
            {
                Console.WriteLine("Insert the filename");
                string fileName = Console.ReadLine();

                myJournal.SaveToFile(fileName);
            }
            else if (userSelection == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a integer between 1 - 5 corresponding to the options \n");
            }
        }

        Console.WriteLine("See You Soon");

    }
}