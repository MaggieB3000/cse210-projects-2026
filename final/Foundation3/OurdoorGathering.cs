public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        Address address = GetAddress();
        return $"\n\nEvent type: Outdoor Gathering\n{GetTitle()}\nDescription: {GetDescription()}\nWeather: {_weather}\n{GetDate()}, {GetTime()}\n{address.FormatedAddress()}";
    }
    public override string ShortDescription()
    {
        return $"\n\nEvent type: Outdoor Gathering\n{GetTitle()}\n{GetDate()}";
    }
}