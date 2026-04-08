public abstract class Activity
{
    private string _type;
    private string _date;
    private int _length;

    public Activity(string type, string date, int length)
    {
        _type = type;
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }

    public abstract string Distance();
    public abstract string Speed();
    public abstract string Pace();
    public string Summary()
    {
        return $"{_date} {_type} ({_length } min) - Distance: {Distance()} miles, Speed: {Speed()} mph, Pace: {Pace()} min per mile";
    }
}