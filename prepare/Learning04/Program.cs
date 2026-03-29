using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new MathAssignment("Margaret Binns", "Blank Assignment", "Section 13.4", "1-15");
        Assignment assignment2 = new WritingAssignment("Bob Joe", "English", "Rando Essay Title");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment2.GetSummary());
    }
}