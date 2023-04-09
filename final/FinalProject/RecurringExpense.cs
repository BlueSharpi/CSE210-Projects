public class RecurringExpense : Expense
{
    // Attributes
    private Schedule _schedule;

    // Constructor
    public RecurringExpense(string title, string category, decimal amount, Schedule schedule) : base(title, category, amount)
    {
        _expenseType = "Recurring";
        _schedule = schedule;
        FormatExpenseData();
    }

    // Methods
    public override void FormatExpenseData()
    {
        _expenseData = string.Format("{0}|{1}|{2}|{3}|{4}", _expenseType, GetTitle(), GetCategory(), GetAmount(), _schedule.GetScheduleData());
    }
    public override string DisplayStatus()
    {
        return _schedule.DisplayNextOccurence();
    }
    public override decimal GetAmountSpent(Budget budget)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        decimal amountSpent = 0;
        foreach (DateOnly date in _schedule.GetCalendarDays())
        {
            if (budget.GetCategory() == GetCategory() && date >= today)
            {
                amountSpent += GetAmount();
            }
        }
        return amountSpent;
    }
}