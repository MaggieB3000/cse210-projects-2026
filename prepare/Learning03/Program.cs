using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 20;
        Random random = new Random();

        while (counter > 0)
        {
            Fraction fraction1 = new Fraction();
            fraction1.SetTop(random.Next(1, 100));
            fraction1.SetBottom(random.Next(1, 100));
            Fraction fraction2 = new Fraction(random.Next(1, 100));
            Fraction fraction3 = new Fraction(random.Next(1, 100), random.Next(1, 100));

            Console.WriteLine($"{fraction1.GetFractionString()}");
            Console.WriteLine($"{fraction1.GetDecimalValue()}");

            Console.WriteLine($"{fraction2.GetFractionString()}");
            Console.WriteLine($"{fraction2.GetDecimalValue()}");

            Console.WriteLine($"{fraction3.GetFractionString()}");
            Console.WriteLine($"{fraction3.GetDecimalValue()}");

            counter = counter - 1;
        }

    }
}