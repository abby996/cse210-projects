using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = DateTime.Parse("2022-11-03"), Duration = 30, Distance = 3 },
            new Cycling { Date = DateTime.Parse("2022-11-03"), Duration = 30, Speed = 12 },
            new Swimming { Date = DateTime.Parse("2022-11-03"), Duration = 30, Laps = 20 }
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.ReadLine();
    }
}