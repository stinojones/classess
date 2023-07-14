

public class Program
{
    static void Main()
    {
        List<Goal> goals = GoalManager.LoadGoals();

        Menu menu = new Menu(goals);
        menu.Show();

        GoalManager.SaveGoals(goals);
    }
}
