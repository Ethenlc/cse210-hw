using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What would you like the fraction number to be?  -  ");

        int input = int.Parse(Console.ReadLine());
        Fraction newFraction = new Fraction(input);


        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());
    }
}