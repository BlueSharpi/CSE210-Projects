public class OneTimeTransaction : Transaction
{
    // Attribute
    private DateOnly _dateOfTransaction = DateOnly.FromDateTime(DateTime.Now);

    // Constructors
    public OneTimeTransaction(string title, decimal amount) : base(title, amount) { }
    public OneTimeTransaction(string title, decimal amount, DateOnly dateOfTransaction) : base(title, amount)
    {
        _dateOfTransaction = dateOfTransaction;
    }

    // Methods
    public override string CheckBudget(Budget budget)
    {
        throw new NotImplementedException();
    }
}