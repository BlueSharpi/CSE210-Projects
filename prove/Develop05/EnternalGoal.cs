public class EternalGoal : Goal
{
    private int _timesCompleted;
    private const int _goalType = 2;


    public EternalGoal(string goalName, string goalDescription, int pointValue, int timesCompleted) : base(goalName, goalDescription, pointValue)
    {
        _timesCompleted = timesCompleted;
        FormatGoalInfo();
    }

    public override void FormatGoalInfo()
    {
        _goalInfo = string.Format("{0}|{1}|{2}|{3}|{4}", _goalType, GetGoalName(), GetGoalDescription(), GetPointValue(), _timesCompleted);
    }
    public override void RecordEvent()
    {
        Animation.Type($"\nEternal Goal: \"{GetGoalName()}\" event recorded!", 1);
        _timesCompleted += 1;
        FormatGoalInfo();
    }
}