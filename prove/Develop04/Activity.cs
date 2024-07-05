using System.IO;
using System.Collections.Generic;
using System.Threading;
// The Asset Class is the base for all the other classes.
// This is responsible for displaying the countdown timer, displaying the animation,
// also responsible for managing random prompts for the specified classes.

public class Activity 
{
    private string _promptsPath = "prompts/";
    private int _sessionTime;
    private string[] _animation = {"|", "/", "-", "\\", "|", "/", "-", "\\"};
    
    public Activity (int session = 0)
    {
        _sessionTime = session;
    }

    public void SetSessionTime () 
    {
        Console.Write("Enter the duration of your session in seconds : ");
        _sessionTime = int.Parse(Console.ReadLine());
        
    }

    public void WelcomeMsg(string activity, string msg)
    {
        Console.WriteLine($"Welcome to the {activity} Activity.\n");
        Console.WriteLine($"{msg}\n");
        SetSessionTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        GetAnimation(5);

    }

    public void CompletionMsg (int session, string activity)
    {
        Console.WriteLine("\nWell done!!!");
        Console.WriteLine($"You have completed another {session} seconds of the {activity} Activity.");
        GetAnimation(5);
        Console.Clear();
    }

    public string GetPrompt (List<string> theList, string file)
    {
        Random random = new ();
        List<string> prompts = new ();
         prompts.AddRange(File.ReadAllLines($"{_promptsPath}/{file}"));
        int randomIndex = random.Next(prompts.Count());
        string thePrompt = prompts[randomIndex];
        theList.Add(thePrompt);
        prompts.RemoveAt(randomIndex);
        if (prompts.Count() == 0)
        {
            prompts.AddRange(theList);
        }
        return thePrompt;
    }

    public void CountDown (int num)
    {
        TheClock(num, 1);
        Console.WriteLine("");
    }

    public void GetAnimation (int num) 
    {
        TheClock(num);
        Console.WriteLine("");
    }
    
    public int GetSessionTime ()
    {
        return _sessionTime;
    }

    public bool TheClock(int num, int activity = 0) 
    {
        DateTime date = DateTime.Now;
        DateTime future = date.AddSeconds(num);
        while(date < future)
        {
            if (activity == 0)
            {
                int i = 0;
                do 
                {
                    Console.Write($"{_animation[i]}");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    i++;  
                    if(i >= _animation.Length)
                    {
                        i = 0;       
                    }
                } while (DateTime.Now < future);
            }
            
            if (activity == 1)
            {
                do 
                { 
                Console.Write(num--.ToString().PadLeft(2, '0'));
                Thread.Sleep(1000);
                Console.Write("\b \b\b \b");
                } while (DateTime.Now < future);
            }
            date = DateTime.Now;
        }
        return false;
    }

}