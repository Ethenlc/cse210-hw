public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "Breathe description")
    {
        for (int i = 0; i < duration/10; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }
        DisplayEndingMessage(duration, "Breathing Activity");
    }
}