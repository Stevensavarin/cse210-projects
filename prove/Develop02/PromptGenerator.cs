public class PromptGenerator
{
    public List<string> _prompts = new List<string>
        {
            "What are you most grateful for today?",
            "Describe a recent challenge you faced and how you handled it.",
            "What is your favorite book and what impact did it have on you?",
            "Share a memorable moment with a loved one.",
            "If you could meet any historical figure, who would it be and why?"
        };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();

        int randomIndex = rnd.Next(_prompts.Count);

        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}