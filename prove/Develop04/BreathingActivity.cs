public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {

    }

    public void Breathe()
    {
        StartMessage();

        DateTime endActivity = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endActivity)
        {
            Console.WriteLine("  Breathe in...");
            CountdownAnimation(4);
            Console.Clear();
            Console.WriteLine("  Hold it...");
            CountdownAnimation(4);
            Console.Clear();
            Console.WriteLine("  Breathe Out...");
            CountdownAnimation(4);
            Console.Clear();
        }

        EndMessage();
    }
}