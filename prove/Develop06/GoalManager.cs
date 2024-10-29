public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }//

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest - Main Menu");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Display Player Info");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoals();
                    break;
                case "4":
                    DisplayPlayerInfo();
                     break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist):");
        string type = Console.ReadLine().ToLower();

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points:");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "checklist":
                Console.WriteLine("Enter target count:");
                int target = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter bonus points:");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Enter the number of the goal to record an event:");
        ListGoals();
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    private void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string goalType = parts[0];
                string[] details = parts[1].Split(",");

                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);

                switch (goalType)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(details[3]);
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        if (isComplete) simpleGoal.RecordEvent();
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(details[3]);
                        int target = int.Parse(details[4]);
                        int bonus = int.Parse(details[5]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                        for (int j = 0; j < amountCompleted; j++) checklistGoal.RecordEvent();
                        _goals.Add(checklistGoal);
                        break;
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}