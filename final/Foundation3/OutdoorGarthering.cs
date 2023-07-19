// OutdoorGathering class
class OutdoorGathering : Event
{
    public string Title { get; set; }
    public DateTime Date  { get; set; }
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetEventDetails()
    {
        string baseDetails = base.GetEventDetails();
        return $"{baseDetails}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}
