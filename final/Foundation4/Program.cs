using System;

class Program
{
    static void Main(string[] args)
    {
        Activity runningActivity = new RunningActivity(new DateTime(2022, 12, 6), 30, 3.0);
        Activity cyclingActivity = new CyclingActivity(new DateTime(2023, 4, 5), 45, 25.0);
        Activity swimmingActivity = new SwimmingActivity(new DateTime(2022, 11, 3), 20, 30);

        List<Activity> activities = new List<Activity> {runningActivity, cyclingActivity, swimmingActivity};

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}