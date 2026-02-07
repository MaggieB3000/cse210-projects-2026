public class Entry
{
    public string _date;
    public string _mood;
    public string _prompt;
    public string _response;

    public string DisplayPrompt()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);

        return prompt;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_response}\n");
    }

    public string GetForStorage()
    {
        return _date + "," + _mood + "," + _prompt + "," + _response;
    }
}