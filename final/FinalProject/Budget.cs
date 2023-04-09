public class Budget
{
    // Attributes
    private string _budgetData;
    private string _category;
    private decimal _spendingLimit;
    private decimal _amountSpent;

    // Constructors
    public Budget(string budgetData, List<Expense> expenseHistory)
    {
        _budgetData = budgetData;
        string[] data = _budgetData.Split("|");
        _category = data[0];
        _spendingLimit = decimal.Parse(data[1]);
        _amountSpent = decimal.Parse(data[2]);
        CalculateAmountSpent(expenseHistory);
        FormatBudgetData();
    }
    public Budget(string category, decimal spendingLimit)
    {
        _category = category;
        _spendingLimit = spendingLimit;
        FormatBudgetData();
    }

    // Methods
    public void FormatBudgetData()
    {
        _budgetData = string.Format("{0}|{1}|{2}", _category, _spendingLimit, _amountSpent);
    }
    public void CalculateAmountSpent(List<Expense> expenseHistory)
    {
        DateTime today = DateTime.Today;
        _amountSpent = 0;
        foreach (Expense expense in expenseHistory)
        {
            _amountSpent += expense.GetAmountSpent(this);
        }
        FormatBudgetData();
    }

    // Getters
    public string GetBudgetData()
    {
        return _budgetData;
    }
    public string GetCategory()
    {
        return _category;
    }
    public decimal GetSpendingLimit()
    {
        return _spendingLimit;
    }
    public decimal GetAmountSpent()
    {
        return _amountSpent;
    }
}