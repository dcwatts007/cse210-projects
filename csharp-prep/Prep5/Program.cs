using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int i)
    {
        return i*i;
    }
    static void DisplayResult(string name,int i)
    {
        Console.WriteLine($"{name}, the square of your number is {i}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(),SquareNumber(PromptUserNumber()));
    }
}