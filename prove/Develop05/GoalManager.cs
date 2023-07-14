
public static class GoalManager
{
    private const string FilePath = "goals.txt";

    public static void SaveGoals(List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            foreach (Goal goal in goals)
            {
                string goalType = goal.GetType().Name;
                string goalLine = $"{goalType},{goal.GetName()},{goal.GetValue()},{goal.GetIsComplete()}";

                if (goal is ChecklistGoal checklistGoal)
                {
                    goalLine += $",{checklistGoal.GetCompletionThreshold()},{checklistGoal.GetCompletionCount()},{checklistGoal.GetBonusValue()}";
                }

                writer.WriteLine(goalLine);
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public static List<Goal> LoadGoals()
    {
        List<Goal> goals = new List<Goal>();

        if (File.Exists(FilePath))
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 4)
                    {
                        string goalType = parts[0];
                        string name = parts[1];
                        int value = int.Parse(parts[2]);
                        bool isComplete = bool.Parse(parts[3]);

                        Goal goal;

                        switch (goalType)
                        {
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal(name, value);
                                break;
                            case nameof(EternalGoal):
                                goal = new EternalGoal(name, value);
                                break;
                            case nameof(ChecklistGoal):
                                if (parts.Length >= 7)
                                {
                                    int threshold = int.Parse(parts[4]);
                                    int completionCount = int.Parse(parts[5]);
                                    int bonusValue = int.Parse(parts[6]);

                                    goal = new ChecklistGoal(name, value, threshold, bonusValue);
                                    ((ChecklistGoal)goal).SetCompletionCount(completionCount);
                                }
                                else
                                {
                                    goal = new ChecklistGoal(name, value, 10, 500);
                                }
                                break;
                            default:
                                goal = null;
                                break;
                        }

                        if (goal != null)
                        {
                            goal.SetIsComplete(isComplete);
                            goals.Add(goal);
                        }
                    }
                }
            }
        }

        return goals;
    }

    public static List<Goal> LoadFile(string filePath)
    {
        List<Goal> goals = new List<Goal>();

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 4)
                    {
                        string goalType = parts[0];
                        string name = parts[1];
                        int value = int.Parse(parts[2]);
                        bool isComplete = bool.Parse(parts[3]);

                        Goal goal;

                        switch (goalType)
                        {
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal(name, value);
                                break;
                            case nameof(EternalGoal):
                                goal = new EternalGoal(name, value);
                                break;
                            case nameof(ChecklistGoal):
                                if (parts.Length >= 7)
                                {
                                    int threshold = int.Parse(parts[4]);
                                    int completionCount = int.Parse(parts[5]);
                                    int bonusValue = int.Parse(parts[6]);

                                    goal = new ChecklistGoal(name, value, threshold, bonusValue);
                                    ((ChecklistGoal)goal).SetCompletionCount(completionCount);
                                }
                                else
                                {
                                    goal = new ChecklistGoal(name, value, 10, 500);
                                }
                                break;
                            default:
                                goal = null;
                                break;
                        }

                        if (goal != null)
                        {
                            goal.SetIsComplete(isComplete);
                            goals.Add(goal);
                        }
                    }
                }
            }
        }

        return goals;
    }
}
