using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), PromptUserNumber());
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
        }
    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int input) {
        int result = input * input;
        return result;
    }
    static string DisplayResult(string name, int number) {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(number)}");
        return "";
    }
}