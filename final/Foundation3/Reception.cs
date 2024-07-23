public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email)
        : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string StandardDetails()
    {
        return base.StandardDetails();
    }

    public override string ShortDetails()
    {
        return $"{this.GetType().Name} - {_title} - {_date}";
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nRSVP Email: {_email}";
    }
}
