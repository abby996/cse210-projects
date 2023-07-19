using System;
using System.Collections.Generic;

// Base Activity class
class Activity
{
    public DateTime Date { get; set; }
    public int Duration { get; set; }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} - Unknown Activity";
    }
}
