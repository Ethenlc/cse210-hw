using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        int userInput = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? - ");

            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput == 1)
                {
                    PromptGenerator newInstance = new PromptGenerator();
                    string prompt = newInstance.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    DateTime currentDate = DateTime.Today;

                    Console.Write("> ");
                    string input = Console.ReadLine();

                    Entry anEntry = new Entry
                    {
                        _date = currentDate.ToString("yyyy/MM/dd"),
                        _promptText = prompt,
                        _entryText = input
                    };

                    theJournal.AddEntry(anEntry);
                }

                else if (userInput == 2)
                {
                    theJournal.DisplayAll();
                }

                else if (userInput == 3)
                {
                    Console.WriteLine("Enter the file name to load: ");
                    string fileName = Console.ReadLine();
                    theJournal.LoadFromFile(fileName);
                }

                else if (userInput == 4)
                {
                    Console.WriteLine("Enter the file name to save: ");
                    string fileName = Console.ReadLine();
                    theJournal.SaveToFile(fileName);
                }
            }

            else if (userInput > 5)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (userInput != 5);
    }
}