public class Swimming : Activity
{
    private int _laps;

    public Swimming(string type, string date, int length, int laps) : base(type, date, length)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }
    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public override string Distance()
    {
        return $"{_laps * 50 / 1000.0 * 0.62:F1}";
    }
    public override string Speed()
    {
        return $"{double.Parse(Distance())/GetLength()*60}";
    }
    public override string Pace()
    {
        return $"{60/double.Parse(Speed())}";
    }
}