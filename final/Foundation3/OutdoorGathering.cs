public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetOutdoorGatheringStandardDetails()
    {
        return GetStandardDetails();
    }

    public string GetOutdoorGatheringShortDetails()
    {
        return GetShortDetails();
    }

    public string GetOutdoorGatheringFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}
