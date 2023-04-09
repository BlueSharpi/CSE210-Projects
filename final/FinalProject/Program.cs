using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu menu = new Menu();
        User user = new User();
        string username;
        string password;

        bool on = true;
        while (on)
        {
            Console.Clear();
            menu.DisplayMenu(1); // Login Menu
            int input = menu.IntPrompt("Select an option from the menu: ");
            bool loggedIn = false;
            switch (input)
            {
                case 1: // Login with an existing username and password
                    break;

                case 2: // Create a new username and password
                    Console.Clear();
                    username = menu.StringPrompt("Create Username: ");
                    password = menu.StringPrompt("Create Password: ");
                    user = new User(username, password);
                    loggedIn = true;
                    break;

                case 3: // Enter as a Guest (fastest way)
                    loggedIn = true;
                    break;

                case 4: // Exit the Program
                    on = false;
                    Console.Clear();
                    Console.Write("Goodbye! ");
                    Thread.Sleep(1500);
                    break;
            }

            while (loggedIn)
            {
                Console.Clear();
                Console.WriteLine(user.GetUsername());
                menu.DisplayMenu(2); // Main Menu
                input = menu.IntPrompt("Select an option from the menu: ");
                List<Expense> expenseHistory = user.GetExpenseHistory();
                List<Budget> budgets = user.GetBudgets();
                switch (input)
                {
                    case 1: // Expenses
                        bool expenseMenu = true;
                        while (expenseMenu)
                        {
                            Console.Clear();
                            menu.DisplayMenu(3); // Expense Menu
                            input = menu.IntPrompt("Select an option from the menu: ");
                            switch (input)
                            {
                                case 2: // Display Expenses
                                    Console.Clear();
                                    menu.DisplayExpenses(expenseHistory);
                                    Menu.GoBack();
                                    break;

                                case 1: // New Expense
                                    Console.Clear();
                                    string title = menu.StringPrompt("Enter expense title: ");
                                    string category = menu.StringPrompt("Enter expense category name: ");
                                    decimal amount = menu.DecimalPrompt("Enter expense amount: ");
                                    Console.Clear();
                                    menu.DisplayMenu(4); // Expense Type Menu
                                    input = menu.IntPrompt("Select an option from the menu: ");
                                    switch (input)
                                    {
                                        case 1: // One Time Expense
                                            Console.Clear();
                                            menu.DisplayMenu(6); // New Date Menu
                                            input = menu.IntPrompt("Select an option from the menu: ");
                                            switch (input)
                                            {
                                                case 1: // Today
                                                    user.AddExpense(expenseHistory, new OneTimeExpense(title, category, amount));
                                                    break;

                                                case 2: // Enter New Date
                                                    DateOnly date = menu.DatePrompt("MM/dd/yyyy");
                                                    user.AddExpense(expenseHistory, new OneTimeExpense(title, category, amount, date));
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.WriteLine("Expense Added! ");
                                            Menu.GoBack();
                                            break;

                                        case 2: // Recurring Expense
                                            bool scheduling = true;
                                            Schedule schedule = new Schedule();
                                            while (scheduling)
                                            {
                                                Console.Clear();
                                                menu.DisplayMenu(7); // Scheduling Menu
                                                input = menu.IntPrompt("Select an option from the menu: ");
                                                switch (input)
                                                {
                                                    case 1:
                                                        Console.Clear();
                                                        schedule.AddDailyOccurence();
                                                        Console.Write("Daily occurance added!");
                                                        Menu.GoBack();
                                                        break;
                                                    case 2: // Add Weekly
                                                        Console.Clear();
                                                        Console.WriteLine(" S | M | T | W | T | F | S ");
                                                        Console.WriteLine(" 1 | 2 | 3 | 4 | 5 | 6 | 7 \n");
                                                        input = menu.IntPrompt("Enter a day #: ");
                                                        schedule.AddWeeklyOccurence(input);
                                                        break;

                                                    case 3: // Add Monthly
                                                        Console.Clear();
                                                        input = menu.IntPrompt("Enter day of the Month: ");
                                                        schedule.AddMonthlyOccurence(input);
                                                        break;

                                                    case 4: // Add Custom
                                                        Console.Clear();
                                                        menu.DisplayMenu(6); // Date Menu
                                                        input = menu.IntPrompt("Select an option from the menu: ");
                                                        DateOnly date = DateOnly.FromDateTime(DateTime.Now);
                                                        switch (input)
                                                        {   //case 1: Today (no input needed)
                                                            case 2: // Enter Date
                                                                date = menu.DatePrompt("MM/dd/yyyy");
                                                                break;
                                                        }
                                                        schedule.AddCalendarDate(date);
                                                        break;

                                                    case 5:
                                                        scheduling = false;
                                                        user.AddExpense(expenseHistory, new RecurringExpense(title, category, amount, schedule));
                                                        Console.Clear();
                                                        Console.WriteLine("Expense Added! ");
                                                        Menu.GoBack();
                                                        break;
                                                }
                                            }
                                            break;
                                    }
                                    break;

                                case 3: // Delete Expense
                                    Console.Clear();
                                    if (expenseHistory.Count > 0)
                                    {
                                        menu.DisplayExpenses(expenseHistory);
                                        input = menu.IntPrompt("Enter Expense Number to delete: ") - 1;
                                        user.RemoveExpense(expenseHistory, input);
                                    }
                                    else
                                    {
                                        Console.Write("Nothing to Delete. ");
                                        Menu.GoBack();
                                    }
                                    break;

                                case 4: // Go Back
                                    expenseMenu = false;
                                    Console.Clear();
                                    Console.Write("Returning to Main Menu... ");
                                    Thread.Sleep(1000);
                                    break;
                            }
                        }
                        break;

                    case 2: // Budget
                        bool budgeting = true;
                        while (budgeting)
                        {
                            Console.Clear();
                            menu.DisplayMenu(5);
                            input = menu.IntPrompt("Select an option from the menu: ");
                            switch (input)
                            {
                                case 1: // Add Budget
                                    Console.Clear();
                                    string category = menu.StringPrompt("Enter Budget Category: ");
                                    decimal spendingLimit = menu.DecimalPrompt("Enter Spending Limit: ");
                                    user.AddBudget(new Budget(category, spendingLimit));
                                    break;

                                case 2: // Display Budgets
                                    Console.Clear();
                                    menu.DisplayBudgets(budgets, expenseHistory);
                                    Menu.GoBack();
                                    break;

                                case 3: // Delete Budget
                                    Console.Clear();
                                    if (budgets.Count > 0)
                                    {
                                        menu.DisplayBudgets(budgets, expenseHistory);
                                        input = menu.IntPrompt("Enter Budget Number to delete: ") - 1;
                                        user.RemoveBudget(budgets, input);
                                    }
                                    else
                                    {
                                        Console.Write("Nothing to Delete. ");
                                        Menu.GoBack();
                                    }
                                    break;

                                case 4:
                                    budgeting = false;
                                    Console.Clear();
                                    Console.Write("Returning to Main Menu... ");
                                    Thread.Sleep(1000);
                                    break;
                            }
                        }
                        break;

                    case 3: // Save
                        CSV.Save(user);
                        Console.Clear();
                        Console.Write(user.GetUsername() + " - Saved!");
                        Menu.GoBack();
                        break;

                    case 4: // Log Out
                        user = new User();
                        loggedIn = false;
                        Console.Clear();
                        Console.WriteLine("Logging out... ");
                        Thread.Sleep(1500);
                        break;
                }
            }

        }

    }
}