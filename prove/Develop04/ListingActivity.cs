public class ListingActivity : Activity
{
    private string[] _promptList =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string activityName, string description) : base(activityName, description) { }

    public void List()
    {
        StartMessage("Get ready to type! ");

        string prompt = GetRandomPrompt(_promptList);
        Console.WriteLine("Question: " + prompt +"\n");
        CountdownAnimation(9);
        Console.Clear();
        Console.WriteLine("Question: " + prompt + "\nType! \n");
        DateTime endActivity = DateTime.Now.AddSeconds(_duration);
        int entries = 0;
        while (DateTime.Now < endActivity)
        {
            Console.ReadLine();
            entries += 1;
        }
        Console.Clear();
        Console.WriteLine("Time!");
        Thread.Sleep(1500);
        Console.Write($"\nYou entered {entries} entries!\n\nContinue > ");
        Console.ReadLine();

        EndMessage();
    }
}
