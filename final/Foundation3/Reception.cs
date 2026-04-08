public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }
    public void SetRsvpEmail(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        Address address = GetAddress();
        return $"\n\nEvent type: Reception\n{GetTitle()}\nDescription: {GetDescription()}\nRSVP Email: {_rsvpEmail}\n{GetDate()}, {GetTime()}\n{address.FormatedAddress()}";
    }
    public override string ShortDescription()
    {
        return $"\n\nEvent type: Reception\n{GetTitle()}\n{GetDate()}";
    }
}