public class Breathing : Activity
{
    public Breathing(string name, string description, List<string> promptList, int duration, List<string> animationCharacterList) : base(name, description, promptList, duration)
    {

    }

    public void BreathingActivity()
    {
        DisplayIntro();
        Console.WriteLine("\nGet Ready... ");
        Animation(2);

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);


        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("\nBreathe in...4");
            Thread.Sleep(1000);
            Console.Write("\b");

            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b");

            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b");

            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b");

            Console.Write("\nBreathe out...4");
            Thread.Sleep(1000);
            Console.Write("\b");

            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b");

            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b");

            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b\n");

            currentTime = DateTime.Now;
        }

        Console.Clear();
        DisplayEnding();
        Console.ReadLine();

    }
}