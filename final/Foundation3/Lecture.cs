public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        Address address = GetAddress();
        return $"\n\nEvent type: Lecture\n{GetTitle()}\nSpeaker: {_speaker}\nDescription: {GetDescription()}\nCapacity: {_capacity}\n{GetDate()}, {GetTime()}\n{address.FormatedAddress()}";
    }
    public override string ShortDescription()
    {
        return $"\n\nEvent type: Lecture\n{GetTitle()}\n{GetDate()}";
    }

}