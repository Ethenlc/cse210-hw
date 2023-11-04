using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your username? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int favNum)
    {
        return favNum * favNum;
    }

    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is {square}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();

        int favNum = PromptUserNumber();

        int square = SquareNumber(favNum);

        DisplayResult(username, square);
    }
}
