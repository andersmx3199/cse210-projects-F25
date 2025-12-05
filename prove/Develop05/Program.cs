using System;
using System.Collections.Generic;

class Program
{
    static int _totalPoints = 0;
    static List<Goals> goals = new List<Goals>();
    static void Main(string[] args)
    {
        // Main Menu
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1) Show Goals");
            Console.WriteLine("2) New Goal");
            Console.WriteLine("3) Record Goal Event");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Load");
            Console.WriteLine("6) Quit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowGoals();
                    break;
                case "2":
                    AddGoal();
                    break;
                case "3":
                    TakeEvent();
                    break;
                case "4":
                    Console.WriteLine("Saved");
                    break;
                case "5":
                    Console.WriteLine("Loaded");
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Unknown option — try again.");
                    break;
            }
        }
    }

    // Show all goals listed, return 'no goals listed' if none are listed yet.
    static void ShowGoals()
    {
        Console.WriteLine("\nGoals:");
        Console.WriteLine($"\nTotal Points: {_totalPoints}");
        if (goals.Count == 0)
        {
            Console.WriteLine("No Goals Listed Yet");
            return;
        }

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    // Add goal section with a new switch statement
    static void AddGoal()
    {
        Console.WriteLine("\nTypes:");
        Console.WriteLine("1) Simple");
        Console.WriteLine("2) Eternal");
        Console.WriteLine("3) Checklist");
        Console.Write("Select type: ");
        string goalchoice = Console.ReadLine();

        Console.Write("Name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("Number of points associated with the goal: ");
        int pts = int.Parse(Console.ReadLine());

        switch (goalchoice)
        {
            case "1":
                goals.Add(new SimpleGoal(goalName, pts));
                break;
            case "2":
                goals.Add(new EternalGoal(goalName, pts));
                break;
            case "3":
                Console.Write("Number of times required to accomplish this goal: ");
                int accomplish = int.Parse(Console.ReadLine());
                Console.Write("Bonus for accomplishing the goal: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new CheckGoal(goalName, pts, accomplish, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type chosen.");
                return;
        }

        Console.WriteLine("Created.");
    }

    // Record an event
    static void TakeEvent()
    {
        // If no goals are included there should be no goal to record.
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        ShowGoals();
        Console.Write("Choose goal number to record: ");
        int choice = int.Parse(Console.ReadLine());

        int awarded = goals[choice - 1].RecordEvent();
        _totalPoints += awarded;
        Console.WriteLine($"Recorded — gained {awarded} points.");

    }
}
