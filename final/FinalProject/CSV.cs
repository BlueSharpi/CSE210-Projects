public class CSV
{
    public static void Save(User user)
    {
        using (StreamWriter outputFile = new StreamWriter(user.GetUsername() + ".txt"))
        {
            outputFile.Write(user.GetUsername() + "|" + user.GetPassword() + "\n");
            foreach (Expense t in user.GetExpenseHistory())
            {
                outputFile.Write(t.GetExpenseData() + ";");
            }
            outputFile.WriteLine();
            foreach (Budget b in user.GetBudgets())
            {
                outputFile.Write(b.GetBudgetData() + ";");
            }
        }
    }
    /*public static User Load(User user)
    {
        string[] lines = System.IO.File.ReadAllLines(user.GetUsername() + ".txt");
        string[] loginInfo = lines[0].Split("|");
        List<Expense> expenseHistory;
        string[] expenses = lines[1].Split("");

        User loadedUser = new User(loginInfo[0], loginInfo[1], expenseHistory, budgets);
    }*/
}