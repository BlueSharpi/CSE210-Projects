using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        int percent = int.Parse(Console.ReadLine());
        string letterGrade = "";
        bool pass = true;
    //Letter Grade
        if (percent >= 90) {letterGrade = "A";}
        else if (percent >= 80) {letterGrade = "B";}
        else if (percent >= 70) {letterGrade = "C";}
        else if (percent >= 60) {letterGrade = "D";}
        else {letterGrade = "F";}

    // "+" or "-"?
        int remainder = percent%10;
        if ( percent > 59 && percent < 97)
        {
            if (remainder >= 7) {letterGrade += "+";}
            else if (remainder < 3) {letterGrade += "-";}
        }
        else if (percent > 100){letterGrade += "+";}

    //Pass or Fail
        if (percent < 70) {pass = false;}
        Console.Write($"Your Grade is... {letterGrade}");
        if (pass == true) {Console.Write("! Congratulations, you passed!");}
        else {Console.Write(". Keep trying!");}


    }
}