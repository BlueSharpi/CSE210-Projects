public class RecurringTransaction : Transaction
{
    // Attributes
    private const string _transactionType = "2";
    private string[] _scheduledDays;
    private Schedule _schedule = null;
    
    // Constructor
    public RecurringTransaction(string title, decimal amount, Schedule schedule) : base(title, amount)
    {
        _schedule = schedule;
        _scheduledDays = _schedule.GetScheduledDays();
    }

    // Methods
    public override string CheckBudget(Budget budget)
    {
        throw new NotImplementedException();
    }
}