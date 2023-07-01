using System;


class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        this.SetActivityName("Reflection Activity");
        this.SetDescription("This activity will help you reflect on times in your life " +
            "when you have shown strength and resilience. " +
            "This will help you recognize the power and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration() / 6;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Think of a time when you stood up for someone else.");
            ShowCountdown(interval);
            Console.WriteLine();
            Console.WriteLine("Think of a time when you did something really difficult.");
            ShowCountdown(interval);
            Console.WriteLine();
            Console.WriteLine("Think of a time when you helped someone in need.");
            ShowCountdown(interval);
            Console.WriteLine();
            Console.WriteLine("Think of a time when you did something truly selfless.");
            ShowCountdown(interval);
        }
        DisplayEndingMessage();
    
        Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
        string input = Console.ReadLine();
        if (input.ToLower() == "quit")
        {
            return;
        }

        foreach (string question in GetQuestions())
        {
            Console.Clear();
            Console.WriteLine(DisplayStartingMessage());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");
            input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine(question);
            ShowCountdown();
        }

        Console.WriteLine("Done");
    }

    private void ShowCountdown(int interval = 1000)
    {
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(interval);
        Console.WriteLine("I'm back!!");
    }
}
