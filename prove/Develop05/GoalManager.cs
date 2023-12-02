using System.IO; 
public class GoalManager
{
    public List<Goal> _goals;
    public int _score;
    public string input;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public string Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public Goal CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which one would you like to create: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Write("Enter Simple Goal name: ");
                string simpleName = Console.ReadLine();
                Console.Write("Enter Simple Goal description: ");
                string simpleDescription = Console.ReadLine();
                Console.Write("Enter Simple Goal points: ");
                int simplePoints = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);
                _goals.Add(simpleGoal); // Add the created goal to the list
                return simpleGoal;

            case "2":
                Console.Write("Enter Eternal Goal name: ");
                string eternalName = Console.ReadLine();
                Console.Write("Enter Eternal Goal description: ");
                string eternalDescription = Console.ReadLine();
                Console.Write("Enter Eternal Goal points: ");
                int eternalPoints = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
                _goals.Add(eternalGoal); // Add the created goal to the list
                return eternalGoal;

            case "3":
                Console.Write("Enter Checklist Goal name: ");
                string checklistName = Console.ReadLine();
                Console.Write("Enter Checklist Goal description: ");
                string checklistDescription = Console.ReadLine();
                Console.Write("Enter Checklist Goal points: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter Checklist Goal bonus points: ");
                int checklistBonusPoints = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, checklistBonusPoints);
                _goals.Add(checklistGoal); // Add the created goal to the list
                return checklistGoal;

            default:
                Console.WriteLine("Invalid choice.");
                return null;
        }
    }


    public void RecordEvent()
    {
        foreach (Goal goal in _goals)
        {
            goal.RecordEvent();
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name: ");

        using (StreamWriter outputFile = new StreamWriter(Console.ReadLine()))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetDetailsString());
            }        
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name: ");

        string[] lines = System.IO.File.ReadAllLines(Console.ReadLine());

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string _shortName = parts[0];
            string _description = parts[1];
        }
    }
}
