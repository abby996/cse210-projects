
public class SimpleGoal : Goals
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return $"[SimpleGoal] {_shortName}";
    }
    public override string GetStringRepresentation()
    {
        return $"[SimpleGoal] {_shortName} - {_description}";
    }
}

