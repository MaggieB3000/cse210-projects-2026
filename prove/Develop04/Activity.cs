public class Activity
{
    private string _name;
    private string _description;
    private List<string> _promptList;
    private int _duration;

    public Activity(string name, string description, List<string> promptList, int duration)
    {
        _name = name;
        _description = description;
        _promptList = promptList;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public List<string> GetPromptList()
    {
        return _promptList;
    }

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Timer()
    {

    }

    public void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}\n\nHow long, in seconds, would you like your session?");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);

        Console.Clear();
    }

    public void DisplayEnding()
    {
        Console.WriteLine($"\nWell done!\n\nYou have completed {_duration} seconds of the {_name} Activity.\nPress 'enter' to continue.\n");
    }

    public string PickRandomPrompt(List<string> promptList)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, promptList.Count);
        string randomPrompt = promptList[randomIndex];
        
        return randomPrompt;
    }

    public void Animation(int PassInCounter)
    {
        int counter = PassInCounter;

        while (counter >= 0)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("—");
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b\b");

            counter = counter - 1;
        }

        Console.Clear();
    }
}