// The class Reflection also inherits from the Asset class. 
// It is responsible for letting the user reflects and ponder on randomly generated prompts. 

public class Reflection : Activity

{
    private string _activityName = "Reflection";
    private string _introMsg = "Take a moment to pause and think about your recent experiences and learnings. This activity will lead you through insightful questions designed to help you gain clarity, foster gratitude, and enhance your personal growth. Let's start this enriching journey together.";
    private List<string> _UsedPrompts  = new ();
    private List<string> _UsedFollowUpPrompt = new ();
    private string _questionFileName = "questionPrompts.txt";
    private string _followUpFileName = "followUpPrompts.txt";

    public Reflection () : base()
    {
    }

    private string GetActivityName()
    {
        return _activityName;
    }
    private void ReflectionPrompt()
    {   
        WelcomeMsg(_activityName, _introMsg);
        Console.WriteLine($"Consider the following prompt:\n\n---- {GetPrompt(_UsedPrompts, _questionFileName)} ----");
        Console.WriteLine("\nOnce you have a thought or idea, press Enter to proceed.");
        Console.ReadLine();
        Console.Clear();
    }

    private void PonderPrompts()
    {
        Console.Write($"> {GetPrompt(_UsedFollowUpPrompt, _followUpFileName)} ");
        GetAnimation(5);
        Console.Write($"> {GetPrompt(_UsedFollowUpPrompt, _followUpFileName)} ");
        GetAnimation(5);
        CompletionMsg(GetSessionTime(), _activityName);
    }

    public void Run()
    {
        ReflectionPrompt();
        PonderPrompts();
    }
}