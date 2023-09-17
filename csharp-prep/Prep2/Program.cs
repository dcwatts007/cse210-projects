using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage? \n(Please write an integer with no additional charaters.)");
        int grade = int.Parse(Console.ReadLine());
        String letter = "";
        if(grade>=90)
        {
            letter = "A";
        }else if(grade>=80)
        {
            letter = "B";
        }else if(grade>=70)
        {
            letter = "C";
        }else if(grade>=60)
        {
            letter = "D";
        }else
        {
            letter = "F";
        }
        if(grade%10>=7&&letter!="A"&&letter!="F")
        {
            letter+= "+";
        }else if(grade%10<=3&&letter!="F")
        {
            letter+="-";
        }
        Console.WriteLine($"You got a {letter}");
        if(grade>=70)
        {
            Console.WriteLine("Congrats! You passed.");
        }else
        {
            Console.WriteLine("Sorry, you didn't pass. Better luck next time.");
        }
    }
}