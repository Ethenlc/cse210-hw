public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name}.");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage(int duration, string name)
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the {name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        _duration = seconds;

        for (int i = _duration * 2; i > 0; i--)
        {
            Console.Write(i % 2 == 0 ? "+" : "-");

            Thread.Sleep(500);

            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.Write(" ");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.Write(" ");
    }
}