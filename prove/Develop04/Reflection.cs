using System;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
    private readonly Random random = new Random();
    private readonly string[] prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly string[] questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Think deeply and reflect...");

        int secondsElapsed = 0;
        while (secondsElapsed < duration)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            Thread.Sleep(3000); // Pause for 3 seconds

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(8000); // Pause for 8 seconds
            }

            secondsElapsed += 11; // Each question takes 8 seconds and the prompt takes 3 seconds
        }
    }
}
