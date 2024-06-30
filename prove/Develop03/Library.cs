public class Library
{
    private List<Scripture> _scriptures;

    public Library()
    {
        _scriptures = new List<Scripture>();
    }

    public void AddScripture(Reference reference, string text)
    {
        _scriptures.Add(new Scripture(reference, text));
    }

    public Scripture SelectRandomScripture()
    {
        Random random = new Random();
        try
        {
            int index = random.Next(_scriptures.Count);
            return _scriptures[index];
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error choosing an aleatory scripture");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error");
            return null;
        }
    }
}