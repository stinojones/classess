using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Mindfulness App!");

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());
            MindfulnessActivity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the Mindfulness App!");
                    return;
                default:
                    Console.WriteLine("Wrong choice. Please try again.");
                    continue;
            }

            activity.StartActivity();
        }
    }
}
