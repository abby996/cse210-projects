class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetDistance()
    {
        return Speed * Duration / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} - Cycling ({Duration} min): Distance {GetDistance():F1} miles, Speed {Speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
