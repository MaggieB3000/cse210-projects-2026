public class PromptGenerator
{
    public List<string> _promptList = new List<string>()
    {
        "What was the best part of your day?", "How did you see the hand of the Lord in your life today?", "What is something you accomplished today that you are proud of?", "What is something I want to do differently tomorrow?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_promptList.Count);
        
        return _promptList[randomIndex];
    }
}