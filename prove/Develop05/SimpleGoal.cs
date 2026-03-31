public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points, complete)
    {
    }

    public override void MarkAsDone()
    {
        SetComplete(true);
    }
}