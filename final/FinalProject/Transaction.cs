public abstract class Transaction
{
    // Attributes
    private string _title;
    private decimal _amount;

    // Constructor
    public Transaction(string title, decimal amount)
    {
        _title = title;
        _amount = amount;
    }

    // Methods
    public abstract string CheckBudget(Budget budget);

    // Getters
    public string GetTitle()
    {
        return _title;
    }
    public decimal GetAmount()
    {
        return _amount;
    }
}