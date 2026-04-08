public class Cycling : Activity
{
    private int _speed;

    public Cycling(string type, string date, int length, int speed) : base(type, date, length)
    {
        _speed = speed;
    }

    public int GetSpeed()
    {
        return _speed;
    }
    public void SetSpeed(int speed)
    {
        _speed = speed;
    }

    public override string Distance()
    {
        return $"{(double)_speed/60*GetLength():F1}";
    }
    public override string Speed()
    {
        return $"{_speed}";
    }
    public override string Pace()
    {
        return $"{60/_speed}";
    }
}