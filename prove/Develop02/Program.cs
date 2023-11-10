using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");

        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            if (userInput == 1)
            {
                PromptGenerator yourInstance = new PromptGenerator();
                Console.WriteLine(yourInstance.GetRandomPrompt());
            }

            else if (userInput == 4)
            {
                Entry newEntry = new Entry();
                newEntry._prompts = 
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
