using System.IO;
public abstract class Goal
{
    public string _shortName; //need to be accessed via GoalManager
    protected string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public abstract string GetDetailsString();
}
