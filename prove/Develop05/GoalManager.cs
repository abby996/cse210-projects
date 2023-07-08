public class GoalManager
{
    private List<Goals> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goals >();
        _score = 0;
    }

    public void Start()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Goal Manager Menu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                
                case "8":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
{
    Console.WriteLine("Goal Names:");
    foreach (var goal in _goals)
    {
        Console.WriteLine(goal.ShortName);
    }
}

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal short name: ");
        string shortName = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        // Additional input and logic for specific goal types
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type goal would you like to create? ");
        string goalType = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(shortName, description, points));
                Console.WriteLine("Simple Goal created successfully.");
                break;
            case "2":
                _goals.Add(new EternalGoal(shortName, description, points));
                Console.WriteLine("Eternal Goal created successfully.");
                break;
            case "3":
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                Console.WriteLine("Checklist Goal created successfully.");
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

public void RecordEvent()
{
    Console.WriteLine("Select the goal to record an event:");
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
    }

    Console.Write("Enter goal number: ");
    int goalNumber = int.Parse(Console.ReadLine()) - 1;

    if (goalNumber >= 0 && goalNumber < _goals.Count)
    {
        var goal = _goals[goalNumber];
        goal.RecordEvent();
        if (goal.IsComplete())
        {
            _score += goal.Points;
            Console.WriteLine($"Goal {_goals[goalNumber].ShortName} completed! You earned {goal.Points} points.");
            _goals.RemoveAt(goalNumber);
        }
    }
    else
    {
        Console.WriteLine("Invalid goal number.");
    }
}}

   