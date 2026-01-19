using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        int userYear;
        PromptUserBirthYear(out userYear);

        int squaredNumber = SquareNumber(favNumber);

        DisplayResult(userName, squaredNumber, userYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int favNumber = int.Parse(userInput);
        return favNumber;
    }

    static void PromptUserBirthYear(out int userYear)
    {
        Console.Write("Please enter the year you were born: ");
        string userInput = Console.ReadLine();
        userYear = int.Parse(userInput);
    }

    static int SquareNumber(int num)
    {
        int squaredNumber = num * num;
        return squaredNumber;
    }

    static void DisplayResult(string userName, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{userName}, you will turn {2026 - birthYear} this year.");
    }

}
