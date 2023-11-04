using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);

        string input;
        int guess;

        do
        {
        Console.WriteLine("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);
        
        if (guess > magicNum)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magicNum)
        {
            Console.WriteLine("Higher");
        }

        } while (guess != magicNum);
        
        Console.WriteLine("Correct!");
    }
}