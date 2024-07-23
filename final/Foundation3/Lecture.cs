public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, string capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
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
        return $"{StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
