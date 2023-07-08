using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userMenuInput = 0;

        List<string> menu = new List<string>()
        {
            "Menu Options:",
            "1. Create New Goals",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };

        GoalManager goalManager = new GoalManager(); // Instantiate the GoalManager object once

        while (userMenuInput != 6)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;

                case 2:
                    goalManager.ListGoalDetails();
                    break;

                case 3:
                    goalManager.SaveGoals();
                    break;

                case 4:
                    goalManager.LoadGoals();
                    break;

                case 5:
                    goalManager.RecordEvent();
                    break;
            }
        }
    }
}

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void SaveGoals()
    {
        // Logic to save the goals to a file or database
        Console.WriteLine("Saving goals...");
    }

    public void LoadGoals()
    {
        // Logic to load the goals from a file or database
        Console.WriteLine("Loading goals...");
    }

    public void CreateGoal()
    {
        // Logic to create a new goal
        Console.WriteLine("Creating a new goal...");
    }

    public void ListGoalDetails()
    {
        // Logic to list goal details
        Console.WriteLine("Listing goal details...");
    }

    public void RecordEvent()
    {
        // Logic to record an event
        Console.WriteLine("Recording an event...");
    }
}

public class Goal
{
    // Define properties and methods for a Goal
}
