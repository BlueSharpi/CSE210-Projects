using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        BreathingActivity b1 = new BreathingActivity("Breathing Activity", "\"Box breathing, also referred to as square breathing, is \na deep breathing technique that can help you slow down \nyour breathing. It works by distracting your mind \nas you count to 4, calming your nervous system, and \ndecreasing stress in your body.\" \n-https://www.webmd.com/balance/what-is-box-breathing \n\nTo perform this technique, you inhale for the count of 4, \nhold that breath for 4 seconds, exhale for 4 seconds, and hold it again.");
        ReflectionAvtivity r1 = new ReflectionAvtivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity l1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        DisplayMenu();

        void DisplayMenu()
        {
            bool on = true;
            while (on)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Thread.Sleep(75);
                Console.WriteLine("   1. Start breathing activity");
                Thread.Sleep(75);
                Console.WriteLine("   2. Start reflecting activity");
                Thread.Sleep(75);
                Console.WriteLine("   3. Start listing activity");
                Thread.Sleep(75);
                Console.WriteLine("   4. Quit");
                Thread.Sleep(75);
                Console.Write("Select a choice from the menu: ");

                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    b1.Breathe();
                }
                if (userInput == 2)
                {
                    r1.Reflect();
                }
                if (userInput == 3)
                {
                    l1.List();
                }
                if (userInput == 4)
                {
                    on = false;
                    Console.Clear();
                    Console.WriteLine("Please come again soon!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Goodbye!");
                    Thread.Sleep(1000);
                }

            }
        }
    }
}
