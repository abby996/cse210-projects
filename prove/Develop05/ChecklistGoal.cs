public class ChecklistGoal : Goals
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

   public override string GetDetailsString()
{
    return $"Amount Completed: {_amountCompleted}/{_target}\nBonus: {_bonus}\n";
}


    public override string GetStringRepresentation()
    {
        return $"[ChecklistGoal] {_shortName} - {_description}";
    }

    public override string ToString()
    {
        return GetStringRepresentation();
    }
}
