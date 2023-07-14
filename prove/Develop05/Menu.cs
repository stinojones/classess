
public class Menu
{
    private List<Goal> goals;

    public Menu(List<Goal> goals)
    {
        this.goals = goals;
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("====== Eternal Quest Program ======");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals from file");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    GoalManager.SaveGoals(goals);
                    break;
                case "5":
                    LoadGoalsFromFile();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the goal value: ");
        int value = int.Parse(Console.ReadLine());

        Goal goal;

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, value);
                break;
            case "2":
                goal = new EternalGoal(name, value);
                break;
            case "3":
                Console.Write("Enter the completion threshold: ");
                int threshold = int.Parse(Console.ReadLine());

                Console.Write("Enter the bonus value: ");
                int bonusValue = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, value, threshold, bonusValue);
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                return;
        }

        goals.Add(goal);

        Console.WriteLine($"Goal '{name}' created with value {value}.");
    }

    private void ListGoals()
    {
        Console.WriteLine("====== Goals ======");
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"Goal: {goal.GetName()}");
            Console.WriteLine($"Status: {(goal.GetIsComplete() ? "[X]" : "[ ]")}");
            Console.WriteLine($"Value: {goal.GetValue()}");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"Completion Count: {checklistGoal.GetCompletionCount()}/{checklistGoal.GetCompletionThreshold()}");
            }
            Console.WriteLine();
        }
    }

    private void RecordEvent()
    {
        Console.Write("Enter the index of the goal to record an event: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            goal.MarkComplete();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    private void LoadGoalsFromFile()
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        List<Goal> loadedGoals = GoalManager.LoadFile(filePath);

        if (loadedGoals.Count > 0)
        {
            goals.Clear();
            goals.AddRange(loadedGoals);
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No goals found in the file.");
        }
    }
}