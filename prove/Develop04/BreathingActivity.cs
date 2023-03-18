public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {

    }

    public void Breathe()
    {
        StartMessage("It's time to clear your mind and focus on your breathing");
        Console.Clear();
        DateTime endActivity = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endActivity)
        {
            BreathAnimation();
            /* Console.WriteLine("  Breathe in...\n");
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
            Console.Clear(); */
        }

        EndMessage();
    }
    public void BreathAnimation()
    {
        string[] animation =
        {
            "    < 1 >    ",
            "   <  2  >   ",
            "  <   3   >  ",
            " <    4    > ",
            "<     1     >",
            "<     2     >",
            "<     3     >",
            "<     4     >",
            " <    1    > ",
            "  <   2   >  ",
            "   <  3  >   ",
            "    < 4 >    ",
            "     <1>     ",
            "     <2>     ",
            "     <3>     ",
            "     <4>     "
        };
        foreach (string s in animation)
        {
            if (s == animation[0])
            {
                Console.Clear();
                Console.WriteLine("  Breathe in...");
            }
            else if (s == animation[4])
            {
                Console.Clear();
                Console.WriteLine("  Hold it...");
            }
            else if (s == animation[8])
            {
                Console.Clear();
                Console.WriteLine("  Breathe out...");
            }
            else if (s == animation[12])
            {
                Console.Clear();
                Console.WriteLine("  Hold it...");
            }
            Console.Write("\r" + s);
            Thread.Sleep(1000);

        }

    }
}