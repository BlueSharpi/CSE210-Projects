using System;

class Program
{
    static void Main(string[] args)
    {
        string restart = "Y";

        while (restart == "Y")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            Console.WriteLine("Try to guess the magic number!" );
            int guess = 0;
            int tries = 0;

            while (guess != number)
            {
                guess = int.Parse(Console.ReadLine());
                tries += 1;
                if (guess < number) {Console.WriteLine("Higher!");}
                else {Console.WriteLine("Lower!");}
            }

            Console.WriteLine($"You got it in {tries} guesses!");
            Console.Write("Type 'Y' to play again! ");
            restart = Console.ReadLine();
        }





    }
}