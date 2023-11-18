using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "0";
        string input2 = "0";

        Reference myReference = new Reference("John", 3, 16);

        string myText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture myScripture = new Scripture(myReference, myText);

        while (input2 != "N" && userInput != "quit")
        {
            do
            {
                Console.Clear();
                Console.Write(myReference.GetDisplayText());
                Console.WriteLine(myScripture.GetDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                userInput = Console.ReadLine();
                
                myScripture.HideRandomWords(5);
            } while (userInput != "quit" && !myScripture.IsCompletelyHidden());
            if (userInput == "quit")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Good job! Would you like to try again? Y/N");
            input2 = Console.ReadLine();
        }
    }
}