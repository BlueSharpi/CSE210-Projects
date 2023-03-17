public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {

    }

    public void Breathe()
    {
        StartMessage("It's time to clear your mind and focus on your breathing");

        DateTime endActivity = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endActivity)
        {
            Console.WriteLine("  Breathe in...\n");
            CountdownAnimation(4);
            Console.Clear();
            Console.WriteLine("  Hold it...\n");
            CountdownAnimation(4);
            Console.Clear();
            Console.WriteLine("  Breathe Out...\n");
            CountdownAnimation(4);
            Console.Clear();
            Console.WriteLine("  Hold it...\n");
            CountdownAnimation(4);
            Console.Clear();
        }

        EndMessage();
    }
}