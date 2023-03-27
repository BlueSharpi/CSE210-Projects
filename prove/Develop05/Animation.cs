public class Animation
{
    public static void Type(string s, int i)
    {
        foreach (char c in s)
        {
            Console.Write(c);
            Thread.Sleep(i);
        }
    }
    public static void Menu(List<string> list, int i)
    {
        foreach (string s in list)
        {
            Console.WriteLine(s);
            Thread.Sleep(i);
        }
    }
    public static void Cheer()
    {
        string[] prompts =
        {
            " -Nice! ",
            " -WOW! ",
            " -Now we're talking! ",
            " -Sweet! ",
            " -Let's go! ",
            " -Impressive! ",
            " -Keep 'em coming! ",
            " -Good work!",
            " -Great! ",
            " -You're pretty good!"
        };

        string randomPrompt = prompts[new Random().Next(0, 9)];
        Console.Write(randomPrompt);
    }
}