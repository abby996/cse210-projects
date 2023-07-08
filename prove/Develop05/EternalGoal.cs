public class EternalGoal : Goals
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recording event for EternalGoal {_shortName}...");
        // Add event recording logic for EternalGoal
    }

    public override bool IsComplete()
    {
        // Add logic to determine if EternalGoal is complete
        return false;
    }

    public override string GetDetailsString()
    {
        return $"EternalGoal: {_shortName}";
    }


    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {_shortName}";
    }
}

