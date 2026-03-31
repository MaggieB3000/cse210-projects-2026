public class ChecklistGoal : Goal
{
    private int _numberNeededToComplete;
    private int _numberCurrentlyComplete;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int numberNeededToComplete, int bonusPoints) : base(name, description, points)
    {
        _numberNeededToComplete = numberNeededToComplete;
        _numberCurrentlyComplete = 0;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(string name, string description, int points, bool complete, int numberNeededToComplete, int numberCurrentlyComplete, int bonusPoints) : base(name, description, points, complete)
    {
        _numberNeededToComplete = numberNeededToComplete;
        _numberCurrentlyComplete = numberCurrentlyComplete;
        _numberCurrentlyComplete = 0;
        _bonusPoints = bonusPoints;
    }

    public int GetNumberNeededToComplete()
    {
        return _numberNeededToComplete;
    }

    public int GetNumberCurrentlyComplete()
    {
        return _numberCurrentlyComplete;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override void MarkAsDone()
    {
        _numberCurrentlyComplete = _numberCurrentlyComplete + 1;

        if (_numberCurrentlyComplete == _numberNeededToComplete)
        {
            SetComplete(true);
            
            int points = GetPoints() + _bonusPoints;
            SetPoints(points);
        }

        Console.WriteLine($"\nYou completed this goal {_numberCurrentlyComplete} times!");
    }
}