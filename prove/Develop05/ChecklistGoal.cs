public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
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

    public override string GetStringRepresentation()
    {
        return $" Checklist Goal,  {_shortName} , {_description} , Points per event: {_points}";
    }
    public override string GetDetailsString()
    {
        return $"Completed: {_amountCompleted}/{_target} - Bonus: {_bonus}";
    }
}
