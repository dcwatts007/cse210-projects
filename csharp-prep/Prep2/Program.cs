using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage? \n(Please write an integer with no additional charaters.)");
        int grade = int.Parse(Console.ReadLine());
        if(grade>=90)
        {
            Console.WriteLine("Congrats on your A!");
        }else if(grade>=80)
        {
            Console.WriteLine("Congrats on you B.");
        }else if(grade>=70)
        {
            Console.WriteLine("You got a C.");
        }else if(grade>=60)
        {
            Console.WriteLine("Shoot, you got a D.");
        }else
        {
            Console.WriteLine("Ouch, you got an F.");
        }
        if(grade>=70)
        {
            Console.WriteLine("Congrats! You passed.");
        }else
        {
            Console.WriteLine("Sorry, you didn't pass. Better luck next time.");
        }
    }
}