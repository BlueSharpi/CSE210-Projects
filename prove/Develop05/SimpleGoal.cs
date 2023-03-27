public class SimpleGoal : Goal
{
    private bool _goalComplete;
    private const int _goalType = 1;

    public SimpleGoal(string goalName, string goalDescription, int pointValue, bool goalComplete) : base(goalName, goalDescription, pointValue)
    {
        _goalComplete = goalComplete;
        FormatGoalInfo();
    }

    public override void FormatGoalInfo()
    {
        _goalInfo = string.Format("{0}|{1}|{2}|{3}|{4}", _goalType, GetGoalName(), GetGoalDescription(), GetPointValue(), _goalComplete);
    }
    public override void RecordEvent()
    {
        if (_goalComplete == true)
        {
            Animation.Type("\nThis goal is already completed!", 1);
        }
        else
        {
            Animation.Type($"\nSimple Goal: \"{GetGoalName()}\" completed!", 1);
            _goalComplete = true;
            FormatGoalInfo();
        }

    }
}