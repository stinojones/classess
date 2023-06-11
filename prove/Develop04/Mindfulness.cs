abstract class MindfulnessActivity
{
    protected string activityName;
    protected string activityDescription;
    protected int duration;

    public MindfulnessActivity(string name, string description)
    {
        activityName = name;
        activityDescription = description;
        duration = 0;
    }

    public void StartActivity()
    {
        Console.WriteLine("Starting " + activityName);
        Console.WriteLine(activityDescription);
        SetDuration();
        PrepareToBegin();
        PerformActivity();
        FinishActivity();
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void FinishActivity()
    {
        Console.WriteLine("Good job! You have completed " + activityName + ".");
        Console.WriteLine("Duration: " + duration + " seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected abstract void PerformActivity();
}