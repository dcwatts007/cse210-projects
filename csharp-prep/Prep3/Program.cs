using System;

class Program
{
    static void Main(string[] args)
    {
        int magic;//the number to be guessed
        int number;//the guess of the person
        int counter = 0;//the amount of guesses used
        //generates a random number for the user to guess
        Random ran = new Random();
        magic = ran.Next(1,101);
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
            counter ++;
        } while(number!=magic);
        Console.WriteLine($"You guessed it in {counter} guesses!");
    }
}