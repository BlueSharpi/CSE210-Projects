using System.IO;
public class AllGoals
{
    private List<Goal> _goals = new List<Goal>();

    public int GetTotalPoints()
    {
        int totalPoints = 0;
        if (_goals.Count() > 0)
        {
            foreach (Goal goal in _goals)
            {
                string[] goalInfo = goal.GetGoalInfo().Split("|");
                int goalType = int.Parse(goalInfo[0]);
                int pointValue = int.Parse(goalInfo[3]);
                if (goalType == 1 && goalInfo[4] == "True")
                {
                    totalPoints += pointValue;
                }
                else if (goalType == 2)
                {
                    totalPoints += pointValue * int.Parse(goalInfo[4]);
                }
                else if (goalType == 3)
                {
                    int reps = int.Parse(goalInfo[4]);
                    int reqreps = int.Parse(goalInfo[5]);
                    if (reps == reqreps)
                    {
                        totalPoints += (pointValue * 9) + (pointValue * reqreps);
                    }
                    else totalPoints += (pointValue * reps);
                }
            }
        }

        return totalPoints;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void DisplayGoals()
    {
        if (_goals.Count() < 1)
        {
            Animation.Type("Nothing to Display.\n", 5);
            return;
        }
        else
        {
            int goalNumber = 0;
            Console.Write("\n===================================\n");
            foreach (Goal goal in _goals)
            {
                Thread.Sleep(100);
                goalNumber += 1;
                string[] goalInfo = goal.GetGoalInfo().Split("|");
                if (goalInfo[0] == "1")
                {   
                    string goalComplete = " ";
                    if (goalInfo[4] == "True")
                    {
                        goalComplete = "✓";
                    }
                    Console.Write($"{goalNumber}. [{goalComplete}] {goalInfo[1]} ({goalInfo[2]})\n");
                }
                else if (goalInfo[0] == "2")
                {
                    Console.Write($"{goalNumber}. [ ] {goalInfo[1]} ({goalInfo[2]}) (Times Completed: {goalInfo[4]})\n");
                }
                else if (goalInfo[0] == "3")
                {   
                    string goalComplete = " ";
                    if (goalInfo[4] == goalInfo[5])
                    {
                        goalComplete = "✓";
                    }
                    Console.Write($"{goalNumber}. [{goalComplete}] {goalInfo[1]} ({goalInfo[2]}) (Times Completed: {goalInfo[4]}/{goalInfo[5]})\n");
                }
            }
        }
    }
    public void SaveGoals()
    {
        Console.Clear();
        if (_goals.Count() < 1)
        {
            Console.Write("\nNothing to save. ");
        }
        else
        {
            Animation.Type("Enter file name to save: ", 1);
            string fileName = Console.ReadLine() + ".txt";
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetGoalInfo());
                }
            }
            Console.Clear();
            Animation.Type("File Saved! ", 1);
        }
        Console.ReadLine();
    }
    public void LoadGoals()
    {
        Console.Clear();
        Animation.Type("Enter file name to load: ", 1);
        string fileName = Console.ReadLine() + ".txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _goals.Clear();
        foreach (string line in lines)
        {
            string[] goalInfo = line.Split("|");

            string goalType = goalInfo[0];
            string goalName = goalInfo[1];
            string goalDescription = goalInfo[2];
            int pointValue = int.Parse(goalInfo[3]);
            if (goalType == "1")
            {
                bool goalComplete = false;
                if (goalInfo[4] == "True")
                {
                    goalComplete = true;
                }
                AddGoal(new SimpleGoal(goalName, goalDescription, pointValue, goalComplete));
            }
            else if (goalType == "2")
            {
                AddGoal(new EternalGoal(goalName, goalDescription, pointValue, int.Parse(goalInfo[4])));
            }
            else if (goalType == "3")
            {
                AddGoal(new ChecklistGoal(goalName, goalDescription, pointValue, int.Parse(goalInfo[4]), int.Parse(goalInfo[5])));
            }

        }
    }
    public void SelectGoal()
    {
        if (_goals.Count() > 0)
        {
            Console.Clear();
            DisplayGoals();
            Animation.Type("Select Goal: ", 1);
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index < _goals.Count())
            {
                _goals[index].RecordEvent();
                Console.ReadLine();
            }
        }
        else
        {
            Console.Clear();
            Animation.Type("\nYou need to create or load a goal first! ", 1);
            Console.ReadLine();
        }
    }
}