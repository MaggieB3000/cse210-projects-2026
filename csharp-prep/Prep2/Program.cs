using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "";
        bool pass = true;
        
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }

        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }

        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }

        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
            pass = false;
        }

        else
        {
            gradeLetter = "F";
            pass = false;
        }

        Console.WriteLine($"Your letter grade is {gradeLetter}.");

        if (pass == true)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("You failed. Better luck next time.");
        }
    }
}