public class OneTimeExpense : Expense
{
    // Attributes
    private DateOnly _dateOfExpense = DateOnly.FromDateTime(DateTime.Now);

    // Constructors
    public OneTimeExpense(string title, string category, decimal amount) : base(title, category, amount)
    {
        _expenseType = "OneTime";
        FormatExpenseData();
    }
    public OneTimeExpense(string title, string category, decimal amount, DateOnly dateOfExpense) : base(title, category, amount)
    {
        _dateOfExpense = dateOfExpense;
        _expenseType = "OneTime";
        FormatExpenseData();
    }

    // Methods
    public override void FormatExpenseData()
    {
        _expenseData = string.Format("{0}|{1}|{2}|{3}|{4}", _expenseType, GetTitle(), GetCategory(), GetAmount(), _dateOfExpense);
    }
    public override string DisplayStatus()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        DateOnly tomorrow = DateOnly.FromDateTime(DateTime.Now.AddDays(1));
        if (_dateOfExpense < today)
        {
            return "Occured on " + _dateOfExpense.ToLongDateString();
        }
        else if (_dateOfExpense == today)
        {
            return "Occured Today";
        }
        else if (_dateOfExpense == tomorrow)
        {
            return "Occurs Tomorrow";
        }
        else return "Will occur on " + _dateOfExpense.ToLongDateString();
    }
    public override decimal GetAmountSpent(Budget budget)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        decimal amountSpent = 0;
        if (budget.GetCategory() == GetCategory() && _dateOfExpense >= today)
        {
            amountSpent += GetAmount();
        }
        return amountSpent;
    }
}