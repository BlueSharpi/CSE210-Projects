public class Menu
{
// Menus
private string[] _loginMenu =
{
    "Welcome to the Budget App!",
    "  1. Login",
    "  2. Create Account",
    "  3. Continue as Guest",
    "  4. Exit Program",
    "Select an option from the menu:"
};
private string[] _mainMenu =
{
    "Main Menu:",
    "  1. Transactions",
    "  2. Budget",
    "  3. Save",
    "  4. Sign Out",
    "Select an option from the menu: "
};
private string[] _tranctionMenu =
{
    "  1. New Tranction",
    "  2. Repeat Previous Transaction",
    "  3. Delete Transaction",
    "Select an option from the menu: "
};
private string[] _budgetMenu =
{
    "Budget Menu",
    "  1. Create Budget",
    "  2. Edit Budget",
    "  3. Delete Budget",
    "Select an option from the menu: "
};
private string[] _dateMenu = 
{
    "Transaction Date: ",
    "  1. Today",
    "  2. Enter Date",
    "Select an option from the menu: "
};

// Methods
public void DisplayMenu(int menuNumber)
{
    string[] selection = {};
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
            selection = _budgetMenu;
            break;
        case 5:
            selection = _dateMenu;
            break;
    }
    foreach (string s in selection)
    {
        Console.WriteLine(s);
        Thread.Sleep(50);
    }
}

// Prompts
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