class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Start breathing...");
        int secondsElapsed = 0;
        while (secondsElapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); 
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); 
            secondsElapsed += 3; 
        }
    }
}