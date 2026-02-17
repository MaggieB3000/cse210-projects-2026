using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        bool loop = true;

        Reference reference = new Reference("Matthew", "16", "1", "4");

        string stringText = "1 The Pharisees also with the Sadducees came, and tempting desired him that he would shew them a sign from heaven. 2 He answered and said unto them, When it is evening, ye say, It will be fair weather: for the sky is red. 3 And in the morning, It will be foul weather to day: for the sky is red and lowring. O ye hypocrites, ye can discern the face of the sky; but can ye not discern the signs of the times? 4 A wicked and adulterous generation seeketh after a sign; and there shall no sign be given unto it, but the sign of the prophet Jonas.And he left them, and departed.";
        List<string> stringWordList = stringText.Split(' ').ToList();
        List<Word> wordWordList = new List<Word>();
        foreach (string stringWord in stringWordList)
        {
            Word word = new Word(stringWord, false);
            wordWordList.Add(word);
        }

        Scripture scripture = new Scripture(wordWordList, reference, 5);

        while (loop == true)
        {
            string userInput = "";

            if (counter == 0)
            {
                Console.WriteLine(reference.DisplayReference());
                Console.WriteLine($"{stringText}");
                Console.WriteLine("\nPress enter to continue or type \'quit\' to finish: ");
                userInput = Console.ReadLine();
                counter = counter + 1;
                if (userInput == "quit" || userInput == "Quit")
                {
                    loop = false;
                }
                Console.Clear();
            }

            else
            {
                Console.WriteLine(reference.DisplayReference());
                Console.WriteLine(scripture.ScriptureGetRenderedText());
                Console.WriteLine("\nPress enter to continue or type \'quit\' to finish: ");
                userInput = Console.ReadLine();

                if (userInput == "quit" || userInput == "Quit")
                {
                    loop = false;
                }
                Console.Clear();

            }
        }
    }
}