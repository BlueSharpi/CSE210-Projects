public class Menu
{
    private List<string> _mainMenu;
    private List<string> _goalMenu;
    public Menu()
    {
        _mainMenu = new List<string>
        {
            "===================================",
            "Menu Options:",
            " 1. Create New Goal",
            " 2. List Goals",
            " 3. Save Goals",
            " 4. Load Goals",
            " 5. Record Event",
            " 6. Quit",
            "Select a choice from the menu: "
        };

        _goalMenu = new List<string>
        {
            "Create which type of Goal?",
            " 1. Simple Goal",
            " 2. Eternal Goal",
            " 3. Checklist Goal"
        };
    }

    public void DisplayMainMenu()
    {
        Animation.Menu(_mainMenu, 100);
    }
    public void DisplayGoalMenu()
    {
        Animation.Menu(_goalMenu, 100);
    }
    public void DisplayAddPoints(int oldPointTotal, int currentPointTotal)
    {
        int pointsGained = currentPointTotal - oldPointTotal;
        int speed = 1000;
        int limit = 100;
        Console.Write($"Points: {oldPointTotal}\n");
        foreach (string s in _mainMenu)
        {
            Console.WriteLine(s);
        }
        Thread.Sleep(1000);
        while (pointsGained > 0)
        {
            speed -= 50;
            limit -= 1;
            oldPointTotal += 1;
            pointsGained -= 1;
            if (limit < 1)
            {
                oldPointTotal += pointsGained/2;
                pointsGained /= 2;
            }
            Console.Clear();
            Console.Write($"Points: {oldPointTotal} + {pointsGained}\n");
            if (pointsGained == 0)
            {
                Console.Clear();
                Console.Write($"Points: {currentPointTotal}");
                Animation.Cheer();
                Console.Write("\n");
            }
            foreach (string s in _mainMenu)
            {
                Console.WriteLine(s);
            }
            Thread.Sleep(Math.Max(1, speed / 10));
        }
    }
}