public class User
{
    // Attributes
    private string _username;
    private string _password;
    private List<Transaction> _transactionHistory = null;
    private Budget _budget = null;

    // Constructors
    public User()
    {
        _username = "Guest Account";
        _password = "";
    }
    public User(string username, string password)
    {
        _username = username;
        _password = password;
    }
    public User(string username, string password, List<Transaction> transactionHistory, Budget budget)
    {
        _username = username;
        _password = password;
        _transactionHistory = transactionHistory;
        _budget = budget;
    }

    // Methods
    public void AddTransaction(Transaction t)
    {
        _transactionHistory.Add(t);
    }
    public void RemoveTransaction(Transaction t)
    {
        _transactionHistory.Remove(t);
    }
    public void AddBudget(Budget b)
    {
        _budget = b;
    }

    public string GetUsername()
    {
        return _username;
    }
    public string GetPassword()
    {
        return _password;
    }
}