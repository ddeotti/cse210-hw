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

    public string GetLectureStandardDetails()
    {
        return GetStandardDetails();
    }

    public string GetLectureShortDetails()
    {
        return GetShortDetails();
    }

    public string GetLectureFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
