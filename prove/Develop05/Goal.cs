

public  abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _setPoints;
    protected int _currentPoint = 0;
    protected string _checkBox = "[ ]";

    public Goal (string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _setPoints = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual void SetIsCompleteToTrue()
    {
        
    }

    public virtual string GetDetailsString()
    {
        return $"{GetCheckMark()} {_shortName} - {_description}";
    }

    public abstract string GetStringRepresentation();

    public int GetCurrentPoint()
    {
        return _currentPoint;
    }

    public string GetGoalName()
    {
        return _shortName;
    }

    public int GetSetPoint()
    {
        return _setPoints;
    }

    public void AddSetPointToCurrentPoint()
    {
        _currentPoint += _setPoints;
    }

    public void SetCheckMark()
    {
        string newCheckBox = _checkBox.Replace(_checkBox, "[✓]");
        _checkBox = newCheckBox;
    }

    public string GetCheckMark()
    {
        return _checkBox;
    }
}