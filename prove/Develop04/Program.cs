using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        string _activity;
        string _description;
        int _duration;

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            _activity = "Breathing Activity";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            Activity newActivity = new Activity(_activity, _description);
            newActivity.DisplayStartingMessage(_activity, _description);
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            BreathingActivity breathingActivity = new BreathingActivity(_duration);
            breathingActivity.DisplayEndingMessage(_duration, _activity);
        }

        if (userInput == 2)
        {
            _activity = "Reflecting Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            Activity newActivity = new Activity(_activity, _description);
            newActivity.DisplayStartingMessage(_activity, _description);
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            ReflectingActivity reflectingActivity = new ReflectingActivity(_duration);
            reflectingActivity.DisplayPrompt();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.WriteLine();
            reflectingActivity.DisplayQuestions();
            newActivity.DisplayEndingMessage(_duration, _activity);
        }

        if (userInput == 3)
        {
            _activity = "Listing Activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            Activity newActivity = new Activity(_activity, _description);
            newActivity.DisplayStartingMessage(_activity, _description);
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            ListingActivity listingActivity = new ListingActivity(_duration);
            listingActivity.GetRandomPrompt();
            listingActivity.GetListFromUser(TimeSpan.FromSeconds(_duration));
            newActivity.DisplayEndingMessage(_duration, _description);
        }
    }
}