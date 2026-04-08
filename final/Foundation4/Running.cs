public class Running : Activity
{
    private int _distance;

    public Running(string type, string date, int length, int distance) : base(type, date, length)
    {
        _distance = distance;
    }

    public int GetDistance()
    {
        return _distance;
    }
    public void SetDistance(int distance)
    {
        _distance = distance;
    }

    public override string Distance()
    {
        return $"{_distance}";
    }
    public override string Speed()
    {
        return $"{(double)_distance/GetLength()*60:F1}";
    }
    public override string Pace()
    {
        return $"{(double)GetLength()/_distance:F1}";
    }
}