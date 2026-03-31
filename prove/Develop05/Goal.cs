using System.Dynamic;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }
    public Goal(string name, string description, int points, bool complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public string getName()
    {
        return _name;
    }
    public string getDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public bool IsComplete()
    {
        return _complete;
    }
    public void SetComplete(bool complete)
    {
        _complete = complete;
    }
    public abstract void MarkAsDone();
}