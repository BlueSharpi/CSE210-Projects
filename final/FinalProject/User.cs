public class User
{
    // Attributes
    private string _username;
    private string _password;
    private List<Expense> _expenseHistory = new List<Expense>();
    private List<Budget> _budgets = new List<Budget>();

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
    public User(string username, string password, List<Expense> expenseHistory, List<Budget> budgets)
    {
        _username = username;
        _password = password;
        _expenseHistory = expenseHistory;
        _budgets = budgets;
    }

    // Methods
    public void AddExpense(List<Expense> expenseList, Expense expense)
    {
        expenseList.Add(expense);
    }
    public void RemoveExpense(List<Expense> expenseList, int index)
    {
        if (expenseList.Count > index)
        {
            expenseList.RemoveAt(index);
            Console.Clear();
            Console.Write("Expense Deleted! ");
            Menu.GoBack();
        }
        else
        {
            Console.Clear();
            Console.Write("Invalid Expense Number. ");
            Menu.GoBack();
        }
    }
    public void RemoveBudget(List<Budget> budgets, int index)
    {
        if (budgets.Count > index)
        {
            budgets.RemoveAt(index);
            Console.Clear();
            Console.Write("Budget Deleted! ");
            Menu.GoBack();
        }
        else
        {
            Console.Clear();
            Console.Write("Invalid Budget Number. ");
            Menu.GoBack();
        }
    }
    public void AddBudget(Budget budget)
    {
        _budgets.Add(budget);
    }

    // Getters
    public string GetUsername()
    {
        return _username;
    }
    public string GetPassword()
    {
        return _password;
    }
    public List<Expense> GetExpenseHistory()
    {
        return _expenseHistory;
    }
    public List<Budget> GetBudgets()
    {
        return _budgets;
    }
}