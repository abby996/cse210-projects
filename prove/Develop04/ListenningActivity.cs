using System;
using System.Threading;

class ListenningActivity : Activity
{
    public ListenningActivity()
    {
        this.SetActivityName("Listening Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life " +
            "by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration() / 6;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Who are people that you appreciate?");
            ShowCountdown(interval);
            Console.WriteLine();
            Console.WriteLine("Who are people that you have helped this week?");
            ShowCountdown(interval);
            Console.WriteLine();
            Console.WriteLine("When have you felt the Holy Ghost this month?");
            ShowCountdown(interval);
            Console.WriteLine();
            Console.WriteLine("Who are some of your personal heroes?");
            ShowCountdown(interval);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }

    private void ShowCountdown(int interval = 1000)
    {
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(interval);
        Console.WriteLine("I'm back!!");
    }
}
