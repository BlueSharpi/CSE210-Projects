public class Menu
{
    // Menus
    private string[] _loginMenu =
    {
    "Welcome to the Budget App!",
    "  1. Login",
    "  2. Create Account",
    "  3. Continue as Guest",
    "  4. Exit Program"
};
    private string[] _mainMenu =
    {
    "Main Menu:",
    "  1. Expenses",
    "  2. Budgets",
    "  3. Save",
    "  4. Sign Out"
};
    private string[] _tranctionMenu =
    {
    "Expense Menu ",
    "  1. New Expense",
    "  2. Display Expenses",
    "  3. Delete Expense",
    "  4. Go Back"
};
    private string[] _transactionTypeMenu =
    {
        "Expense Type",
        "  1. One Time Expense",
        "  2. Recurring Expense"
    };
    private string[] _budgetMenu =
    {
    "Budget Menu",
    "  1. Create Budget",
    "  2. Display Budgets",
    "  3. Delete Budget",
    "  4. Go Back"
};
    private string[] _dateMenu =
    {
    "Date of Expense: ",
    "  1. Today",
    "  2. Enter Date"
};
    private string[] _scheduleMenu =
    {
        "Add Schedule:",
        "  1. Daily",
        "  2. Weekly",
        "  3. Monthly",
        "  4. Custom Date",
        "  5. Finish"
    };

    // Methods
    public void DisplayMenu(int menuNumber)
    {
        string[] selection = { };
        switch (menuNumber)
        {
            case 1:
                selection = _loginMenu;
                break;
            case 2:
                selection = _mainMenu;
                break;
            case 3:
                selection = _tranctionMenu;
                break;
            case 4:
                selection = _transactionTypeMenu;
                break;
            case 5:
                selection = _budgetMenu;
                break;
            case 6:
                selection = _dateMenu;
                break;
            case 7:
                selection = _scheduleMenu;
                break;
        }
        foreach (string s in selection)
        {
            Console.WriteLine(s);
            Thread.Sleep(50);
        }
    }
    public void DisplayExpenses(List<Expense> transactionHistory)
    {
        int i = 0;
        if (transactionHistory == null)
        {
            return;
        }
        if (transactionHistory.Count > 0)
        {
            foreach (Expense transaction in transactionHistory) 
            {
                i += 1;
                Console.WriteLine(i + ". " + transaction.GetTitle() + " : -$" + transaction.GetAmount());
                Console.WriteLine("    " + transaction.DisplayStatus());
                Thread.Sleep(100);
            }
        }
        else Console.WriteLine("Nothing to display.");
    }
    public void DisplayBudgets(List<Budget> budgets, List<Expense> expenseHistory)
    {
        int i = 0;
        if (budgets == null)
        {
            return;
        }
        if (budgets.Count > 0)
        {
            foreach (Budget budget in budgets) 
            {
                budget.CalculateAmountSpent(expenseHistory);
                i += 1;
                Console.WriteLine(i + ". " + budget.GetCategory());
                Console.WriteLine("   Spending Limit: $" + budget.GetSpendingLimit());
                Console.WriteLine("   Amount Spent:   $" + budget.GetAmountSpent());
                Thread.Sleep(100);
            }
        }
        else Console.WriteLine("Nothing to display.");
    }
    public static void GoBack()
    {
        Thread.Sleep(1000);
        Console.Write("\n< Back ");
        Console.ReadLine();
    }

    // Prompt Methods
    public DateOnly DatePrompt(string dateFormat)
    {
        DateOnly date;
        Console.Write($"Enter calendar date in format {dateFormat} : ");
        string userInput = Console.ReadLine();
        while (!DateOnly.TryParseExact(userInput, dateFormat, out date))
        {
            Console.Write($"\rInvalid entry. Enter calendar date in format {dateFormat} : ");
            userInput = Console.ReadLine();
        }
        return date;
    }
    public int IntPrompt(string prompt)
    {
        Console.Write(prompt);
        int userInput = int.Parse(Console.ReadLine());
        return userInput;
    }
    public decimal DecimalPrompt(string prompt)
    {
        Console.Write(prompt);
        decimal userInput = decimal.Parse(Console.ReadLine());
        return userInput;
    }
    public string StringPrompt(string prompt)
    {
        Console.Write(prompt);
        string userInput = Console.ReadLine();
        return userInput;
    }
}