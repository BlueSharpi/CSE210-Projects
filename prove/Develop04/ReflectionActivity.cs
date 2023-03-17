public class ReflectionAvtivity : Activity
{
    private string[] _promptList =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private string[] _questionList =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionAvtivity(string activityName, string description) : base(activityName, description) { }

    public void Reflect()
    {
        StartMessage("Remember to keep an open mind");
        string prompt = GetRandomPrompt(_promptList);
        Console.WriteLine(prompt);
        WaitAnimation(5, "");
        DateTime endActivity = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endActivity)
        {
            Console.Clear();
            Console.WriteLine(prompt);
            Console.WriteLine("\n" + GetRandomPrompt(_questionList));
            WaitAnimation(6, "");
        }

        EndMessage();
    }
}