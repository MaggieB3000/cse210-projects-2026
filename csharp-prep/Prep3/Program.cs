using System;

class Program
{
    static void Main(string[] args)
    {
        int userGuess = -1;

        Random randomMagicNumber = new Random();
        int magicNumber = randomMagicNumber.Next(1,101);


        //Console.Write("What is the magic number? ");
        //string userInput = Console.ReadLine();
        //magicNumber = int.Parse(userInput);

        while (userGuess != magicNumber) 
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

        } 


    }
}