

class Running : Activity
{
    public double Distance { get; set; }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / Duration * 60;
    }

    public override double GetPace()
    {
        return Duration / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} - Running ({Duration} min): Distance {Distance} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
