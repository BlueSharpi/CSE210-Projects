public class Activity
{
    private string _activityName;
    private string _description;
    protected int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartMessage(string message)
    {
        Console.Clear();
        Console.Write($"Welcome to the {_activityName}. ");
        Thread.Sleep(1500);
        Console.Write($"\n\n{_description} ");
        Thread.Sleep(1500);
        Console.Write("\n\nHow long would you like your session to last (in seconds)? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        WaitAnimation(1, message);
        WaitAnimation(4, "\nGet Ready");
        Console.Clear();
    }
    public void EndMessage()
    {
        WaitAnimation(5, "Winding down");
        Console.Clear();
        Console.WriteLine("\nWell done!!");
        Thread.Sleep(1500);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_activityName}.\n");
        Thread.Sleep(1500);
        Console.Write("Return to Menu > ");
        Console.ReadLine();
    }
    public void CountdownAnimation(int seconds)
    {
        DateTime stopTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < stopTime)
        {   
            for (int s = seconds; s > 0; s--)
            {
                Console.Write($"\r    (] - {s} - [)    ");
                Thread.Sleep(450);
                Console.Write($"\r    O( - {s} - )O    ");
                Thread.Sleep(25);
                Console.Write($"\r   O ( - {s} - ) O   ");
                Thread.Sleep(25);
                Console.Write($"\r  O  ( - {s} - )  O  ");
                Thread.Sleep(50);
                Console.Write($"\r O   ( - {s} - )   O ");
                Thread.Sleep(100);
                Console.Write($"\rO    ( - {s} - )    O");
                Thread.Sleep(150);
                Console.Write($"\r O   ( - {s} - )   O ");
                Thread.Sleep(100);
                Console.Write($"\r  O  ( - {s} - )  O  ");
                Thread.Sleep(50);
                Console.Write($"\r   O ( - {s} - ) O   ");
                Thread.Sleep(25);
                Console.Write($"\r    O( - {s} - )O    ");
                Thread.Sleep(25);
            }
        }
    }
    public void WaitAnimation(int seconds, string s)
    {   
        Console.Write($"{s}    ");
        DateTime stopTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < stopTime)
        {
            Console.Write($"\b\b\b\b.   ");
            Thread.Sleep(200);
            Console.Write($"\b\b\b\b..  ");
            Thread.Sleep(200);
            Console.Write($"\b\b\b\b... ");
            Thread.Sleep(500);
            Console.Write($"\b\b\b\b .. ");
            Thread.Sleep(200);
            Console.Write($"\b\b\b\b  . ");
            Thread.Sleep(200);
            Console.Write($"\b\b\b\b    ");
            Thread.Sleep(500);
        }
    }
    public string GetRandomPrompt(List<string> promptList)
    {
        int r = new Random().Next(0, promptList.Count);
        return promptList[0];
    }
}