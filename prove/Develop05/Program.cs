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
            "1. Create New Goal",
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

                

                case 5:
                    goalManager.RecordEvent();
                    break;
            }
        }
    }
}



