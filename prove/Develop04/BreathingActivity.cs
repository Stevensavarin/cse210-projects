// The Breathing Class inherits from the Asset class. It is responsible
// for giving the user a breathing session base on the duration of the session.

public class Breathing : Activity
{
    private string _activityName = "Breathing"; 
    private string _introMsg = "This guided exercise will help you achieve relaxation and tranquility through slow, intentional breathing. Let's get started.";

    public Breathing ()
    {
    }
    private void Breath ()
    {
        DateTime date = DateTime.Now;
        WelcomeMsg(_activityName, _introMsg);
        DateTime future = date.AddSeconds(GetSessionTime());
        int breathingLength = 5;
        
        do
        {
            Console.Write("breathe IN... ");
            CountDown(breathingLength);
            Console.Write("breathe OUT... ");
            CountDown(breathingLength);
            Console.WriteLine("");
        } while (DateTime.Now < future);
        CompletionMsg(GetSessionTime(), _activityName);
    }

    public void Run()
    {
        Breath();
    }
}