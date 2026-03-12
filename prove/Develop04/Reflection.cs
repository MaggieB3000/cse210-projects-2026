public class Reflection : Activity
{
    private List<string> _questionList;

    public Reflection(string name, string description, List<string> promptList, int duration, List<string> animationCharacterList, List<string> questionList) : base(name, description, promptList, duration)
    {
        _questionList = questionList;
    }

    public List<string> GetQuestionList()
    {
        return _questionList;
    }

    public void ReflectionActivity()
    {
        List<string> promptList = GetPromptList();
        string prompt = PickRandomPrompt(promptList);

        DisplayIntro();
        int duration = GetDuration();
        Console.WriteLine("\nGet Ready...");
        Animation(2);
        Console.Clear();

        Console.WriteLine($"Consider the following prompt:\n\n---{prompt}---\n\nWhen you have something in mind, press 'enter' to continue.");
        Console.ReadLine();
        Console.Write("\n\nNow ponder each of the following questions as they relate to this experience.\nYou may begin in: 3");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.WriteLine($">{PickRandomPrompt(_questionList)}");
            Animation(5);

            currentTime = DateTime.Now;
        }

        Console.Clear();
        DisplayEnding();
        Console.ReadLine();
    }
}