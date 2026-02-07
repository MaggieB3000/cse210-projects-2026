using System;

class Program
{
    static void Main(string[] args)
    {
        bool menu = true;
        Journal journal = new Journal();

        while (menu == true)
        {
            Console.WriteLine("Welcome to the Journal Program!\n\nPlease select one of the following options:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nWhat would you like to do?");
            string menuInput = Console.ReadLine();
            int choice = int.Parse(menuInput);

            if (choice == 1)
            {
                journal.AddEntry();
            }

            else if (choice == 2)
            {
                journal.DisplayEntries();
            }

            else if (choice == 3)
            {
                journal.LoadFile();
            }

            else if (choice == 4)
            {
                journal.SaveFile();
            }

            else if (choice == 5)
            {
                Console.WriteLine("\nSee you again next time!");
                menu = false;
            }

            else
            {
                Console.WriteLine("\nInvalid choice, try again!\n");
            }
        }
    }
}