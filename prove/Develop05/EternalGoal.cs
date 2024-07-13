
public class EternalGoal : Goal
{
    private string _typeOfGoal;

    public EternalGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            AddSetPointToCurrentPoint();
        }
    }

    public override bool IsComplete()
    {
         return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_shortName} | {_description} | {_setPoints}";
    }


}