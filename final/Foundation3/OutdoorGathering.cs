public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
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
        return $"{StandardDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}
