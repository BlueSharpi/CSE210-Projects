using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        AllGoals allGoals = new AllGoals();
        Menu m = new Menu();
        int mainMenuInput = 0;
        int oldPointTotal = 0;

        while (mainMenuInput != 6)
        {
            Console.Clear();
            if (oldPointTotal < allGoals.GetTotalPoints())
            {
                m.DisplayAddPoints(oldPointTotal, allGoals.GetTotalPoints());
                oldPointTotal = allGoals.GetTotalPoints();
            }
            else
            {
                Animation.Type("Points: " + allGoals.GetTotalPoints().ToString() + "\n", 50);
                m.DisplayMainMenu();
            }
            mainMenuInput = int.Parse(Console.ReadLine());

            switch (mainMenuInput)
            {
                case 1: // Create New Goal
                    Console.Clear();
                    m.DisplayGoalMenu();
                    int goalMenuInput = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Animation.Type("Enter Goal Name: ", 3);
                    string goalName = Console.ReadLine();
                    Console.Clear();
                    Animation.Type("Enter Goal Description: ", 3);
                    string goalDescription = Console.ReadLine();
                    Console.Clear();
                    Animation.Type("Enter Point Value: ", 3);
                    int pointValue = int.Parse(Console.ReadLine());

                    switch (goalMenuInput)
                    {
                        case 1: // Simple Goal
                            allGoals.AddGoal(new SimpleGoal(goalName, goalDescription, pointValue, false));
                            break;
                        case 2: // Eternal Goal
                            allGoals.AddGoal(new EternalGoal(goalName, goalDescription, pointValue, 0));
                            break;
                        case 3: // Checklist Goal
                            Console.Clear();
                            Animation.Type("Enter Required Repetitions: ", 3);
                            int requiredRepetitions = int.Parse(Console.ReadLine());
                            allGoals.AddGoal(new ChecklistGoal(goalName, goalDescription, pointValue, 0, requiredRepetitions));
                            break;
                    }
                    break;

                case 2: // List Goals
                    Console.Clear();
                    allGoals.DisplayGoals();
                    Console.Write("Continue > ");
                    Console.ReadLine();
                    break;

                case 3: // Save Goals
                    allGoals.SaveGoals();
                    break;

                case 4: // Load Goals
                    allGoals.LoadGoals();
                    break;

                case 5: // Record Event
                    allGoals.SelectGoal();
                    break;

                case 6: // Quit
                    Animation.Type("\nGoodbye! ", 30);
                    break;
            }
        }

    }
}