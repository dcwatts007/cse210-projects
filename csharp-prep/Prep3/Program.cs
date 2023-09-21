using System;

class Program
{
    static void Main(string[] args)
    {
        int magic;
        int number;
        Console.WriteLine("Whit is the magic number?");
        magic = int.Parse(Console.ReadLine());
        //loops until the user guesses the magic number. 
        do
        {
            Console.WriteLine("What is your guess?");
            number = int.Parse(Console.ReadLine());
            //checks if the guess is lower or higher than the magic number
            if(number>magic)
            {
                Console.WriteLine("Lower");
            }else if(number<magic)
            {
                Console.WriteLine("Higher");
            }
        } while(number!=magic);
        Console.WriteLine("You guessed it!");
    }
}