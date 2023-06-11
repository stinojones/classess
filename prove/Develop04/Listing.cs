class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Start listing...");
        int secondsElapsed = 0;
        Random random = new Random();
        while (secondsElapsed < duration)
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);

            Console.WriteLine("Think about it...");
            Thread.Sleep(5000); // Pause for 5 seconds

            Console.WriteLine("Enter your items (one per line):");
            int itemCount = 0;
            while (secondsElapsed < duration)
            {
                string item = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(item))
                    break;
                itemCount++;
                secondsElapsed += 5; // Each item takes 5 seconds
            }

            Console.WriteLine("You listed " + itemCount + " items.");
        }
    }
}