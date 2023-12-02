using System;

class Program
{
    static void Main(string[] args)
    {

 // Create some goals
        List<Goal> goals = new List<Goal>{};

        // Initialize GoalManager with goals
        GoalManager goalManager = new GoalManager(goals, 0);

        // Interact with GoalManager
        string choice;

        do
        {
            choice = goalManager.Start();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;

                case "2":
                    goalManager.ListGoalDetails();
                    break;

                case "3":
                    goalManager.SaveGoals();
                    break;

                case "4":
                    goalManager.LoadGoals();
                    break;

                case "5":
                    goalManager.RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("Quitting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        } while (choice != "6");

        // Display player info and final score
        goalManager.DisplayPlayerInfo();
        Console.WriteLine($"Final Score: {goalManager._score}");    }
}