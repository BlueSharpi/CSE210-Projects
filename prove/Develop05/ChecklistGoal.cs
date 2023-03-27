public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _requiredRepetitions;
    private const int _goalType = 3;

    public ChecklistGoal(string goalName, string goalDescription, int pointValue, int timesCompleted, int requiredRepetitions) : base(goalName, goalDescription, pointValue)
    {
        _timesCompleted = timesCompleted;
        _requiredRepetitions = requiredRepetitions;
        FormatGoalInfo();
    }

    public override void FormatGoalInfo()
    {
        _goalInfo = string.Format("{0}|{1}|{2}|{3}|{4}|{5}", _goalType, GetGoalName(), GetGoalDescription(), GetPointValue(), _timesCompleted, _requiredRepetitions);
    }
    public override void RecordEvent()
    {
        if (_timesCompleted < _requiredRepetitions)
        {
            Animation.Type($"\nChecklist Goal: \"{GetGoalName()}\" event recorded!", 1);
            _timesCompleted += 1;
        }
        else
        {
            Animation.Type($"\nThis goal has already been completed {_timesCompleted}/{_requiredRepetitions} times!", 1);
        }
        FormatGoalInfo();
    }
}