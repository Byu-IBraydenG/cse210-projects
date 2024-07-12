using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Initialization logic if necessary
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist): ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target count for checklist goal: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points for checklist goal: ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new CheckListGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
    }

    // Not showing scores and recording them.
    public void RecordEvent()
    {
        Console.WriteLine("Enter the goal number to record an event: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 0 || goalNumber >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[goalNumber];
        goal.RecordEvent();
        _score += goal.Points; // Assuming Points is a property in Goal class that returns the points earned

        Console.WriteLine("Event recorded.");
    }

    public void SaveGoals()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        var data = new
        {
            Goals = _goals,
            Score = _score
        };

        string jsonString = JsonSerializer.Serialize(data, options);
        File.WriteAllText("goals.json", jsonString);
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.json"))
        {
            string jsonString = File.ReadAllText("goals.json");
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}: {_goals[i].GetStringRepresentation()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}: {_goals[i].GetDetailString()}");
        }
    }

    private class SaveData
    {
        public List<Goal> Goals { get; set; }
        public int Score { get; set; }
    }
}
