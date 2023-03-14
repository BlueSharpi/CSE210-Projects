using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture s;

        Console.Write("Add new Scripture? ( y or n ) ");
        string input = Console.ReadLine();
        if (input == "n")
        {
            s = new Scripture(new Reference("1 Nephi", "3", "6", "7"), "6 Therefore go, my son, and thou shalt be favored of the Lord, because thou hast not murmured. \n7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        }
        else
        {
            Console.Write("Book: ");
            string b = Console.ReadLine();
            Console.Write("Chapter: ");
            string c = Console.ReadLine();
            Console.Write("Multiple verses? ( y or n ) ");
            input = Console.ReadLine();
            if (input == "y")
            {
                Console.Write("Starting Verse #: ");
                string v = Console.ReadLine();
                Console.Write("End Verse #: ");
                string e = Console.ReadLine();
                Console.Write("Please input text to memorize: ");
                s = new Scripture(new Reference(b, c, v, e), Console.ReadLine());
            }
            else
            {
                Console.Write("Verse: ");
                string v = Console.ReadLine();
                Console.Write("\nPlease input text to memorize: ");
                s = new Scripture(new Reference(b, c, v), Console.ReadLine());
            }
        }

        Console.Clear();
        Console.WriteLine("Thank you.");
        Console.WriteLine("When your scripture is displayed, press Enter to hide some of the words.");
        Console.WriteLine("If you get stuck, you can reveal words by typing any key and then Enter.");
        Console.WriteLine("Type 'quit' at any time to exit the program.");
        Console.WriteLine("\nPress Enter to Continue > ");
        Console.ReadLine();

        Console.Clear();
        s.DisplayScripture();
        while (s.GameOn())
        {
            Console.WriteLine();
            input = Console.ReadLine();
            Console.Clear();
            if (input == "")
            {
                s.HideWords();
            }
            else if (input == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                s.RevealWords();
            }
            s.DisplayScripture();
            
        }
        Console.WriteLine("\n\nYou did it! ...Right? Let's see if you can recite it from memory.\n\n");
    }
}