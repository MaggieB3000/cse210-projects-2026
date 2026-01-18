using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        int listSum = 0;
        int listMax = 0;

        Console.WriteLine("Hello Prep4 World!");

        List<int> numberList = new List<int>();

        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers and type \'0\' when you\'re finished. ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numberList.Add(userNumber);
            }
        }

        //#1 & #3
        foreach (int number in numberList)
        {
            listSum = listSum + number;

            if (listMax < number)
            {
                listMax = number;
            }
        }

        //#2
        float listAverage = listSum / numberList.Count;

        Console.WriteLine($"The sum is: {listSum}");
        Console.WriteLine($"The average is: {listAverage}");
        Console.WriteLine($"The max/largest number is: {listMax}");

    }
}