public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent(){
        
    }

    public override bool IsComplete(){

        return false;
    }

    public override string GetStringRepresentation(){
        return $"Eternal Goal, {_shortName} , {_description} , Points per event: {_points}";
    }
    public override string GetDetailsString()
    {
        throw new NotImplementedException(); //seems like these were required for the child classes
    }
}
