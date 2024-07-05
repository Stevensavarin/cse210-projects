// The Listing Class as well inherits from the Asset class. 
// It allows the user to list down things/notes based on randomly generated prompts

public class Listing : Activity
{
    private string _activityName = "Listing";
    private string _introMsg = "This activity will help you listening your thoughts and feelings in response to a specific prompt. It's an effective way to reflect on your experiences and better understand your emotions.";
    private string _listFileName = "list.txt";
    private List<string> _UsedListingPrompt = new ();
    private List<string> _userInputs;

    public Listing()
    {
    }

    private void DisplayListItem()
    {
        DateTime date = DateTime.Now;
        WelcomeMsg(_activityName, _introMsg);
        DateTime future = date.AddSeconds(GetSessionTime());

        Console.WriteLine($"List as many responses you can to the following prompt:\n\n---- {GetPrompt(_UsedListingPrompt, _listFileName)} ----");
        Console.Write("You may begin in: ");
        CountDown(5);

        _userInputs = new ();

        do
        {
          Console.Write("> ");
          string listResponse = Console.ReadLine();
          _userInputs.Add(listResponse);
        } while (DateTime.Now < future);
    }

    private void ListAmount()
    {
        Console.WriteLine($"You listed {_userInputs.Count} items!");
        CompletionMsg(GetSessionTime(), _activityName);
    }

    public void Run()
    {
        DisplayListItem();
        ListAmount();
    }
}
