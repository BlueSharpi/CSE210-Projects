public abstract class Goal
{
    protected string _goalInfo;
    private string _goalName;
    private string _goalDescription;
    private int _pointValue;

    public Goal(string goalName, string goalDescription, int pointValue)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _pointValue = pointValue;
    }

    public string GetGoalInfo()
    {
        return _goalInfo;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }

    public abstract void FormatGoalInfo();
    public abstract void RecordEvent();
}