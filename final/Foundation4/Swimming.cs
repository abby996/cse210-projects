class Swimming : Activity
{
    public int Laps { get; set; }
    private const double LapDistanceMeters = 50;
    private const double MilesPerKilometer = 0.62;

    public override double GetDistance()
    {
        return Laps * LapDistanceMeters / 1000 * MilesPerKilometer;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Duration * 60;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} - Swimming ({Duration} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
