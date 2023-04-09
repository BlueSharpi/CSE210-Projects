public abstract class Expense
{
    // Attributes
    protected string _expenseType;
    protected string _expenseData;
    private string _title;
    private string _category;
    private decimal _amount;

    // Constructor
    public Expense() { }
    public Expense(string title, string category, decimal amount)
    {
        _title = title;
        _category = category;
        _amount = amount;
    }

    // Methods
    public abstract void FormatExpenseData();
    public abstract string DisplayStatus();
    public abstract decimal GetAmountSpent(Budget budget);

    // Getters
    public string GetExpenseType()
    {
        return _expenseType;
    }
    public string GetExpenseData()
    {
        return _expenseData;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetCategory()
    {
        return _category;
    }
    public decimal GetAmount()
    {
        return _amount;
    }
}