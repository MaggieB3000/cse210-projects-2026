public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesCompleted = 0;
    }
    public EternalGoal(string name, string description, int points, bool complete, int timesCompleted) : base(name, description, points, complete)
    {
        _timesCompleted = timesCompleted;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }
    public override void MarkAsDone()
    {
        _timesCompleted = _timesCompleted + 1;

        Console.WriteLine($"\nYou completed this goal {_timesCompleted} times!");
    }
}