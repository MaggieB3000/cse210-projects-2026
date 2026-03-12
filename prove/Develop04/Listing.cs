public class Listing : Activity
{
    public Listing(string name, string description, List<string> promptList, int duration, List<string> animationCharacterList) : base(name, description, promptList, duration)
    {

    }

    public void ListingActivity()
    {
        int counter = 0;
        DisplayIntro();
        int duration = GetDuration();
        Console.WriteLine("Get Ready...");
        Animation(2);

        Console.Write($"\nList as many responces as you can to the following prompt:\n\n--- {PickRandomPrompt(GetPromptList())} ---\n\nYou may begin in: 3");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write(">");
            Console.ReadLine();

            counter = counter + 1;
            currentTime = DateTime.Now;
        }

        Console.Clear();
        Console.WriteLine($"You listed {counter} items!");
        DisplayEnding();
        Console.ReadLine();
    }
}