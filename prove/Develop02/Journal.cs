public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Entries in the journal:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            if (file.EndsWith(".csv"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
            }
            else 
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date: {entry._date}");
                    outputFile.WriteLine($"Prompt: {entry._promptText}");
                    outputFile.WriteLine(entry._entryText);
                    outputFile.WriteLine();
                }
            }
        }
    }

    public void LoadFromFile(string file)
    {

        try
        {
            if (file.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string date = parts[0];
                string prompt = parts[1];
                string userInput = parts[2];

                Console.WriteLine($"Date: {date} - Prompt: {prompt} \n{userInput}\n");
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string journalEntries = reader.ReadToEnd();
                Console.WriteLine(journalEntries);
            }
        }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"\nError: The file '{file}' was not found.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn error occurred: {ex.Message}\n");
        }
    }
}