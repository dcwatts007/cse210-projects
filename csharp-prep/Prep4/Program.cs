using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;
        int sum = 0;
        double average = 0;
        int big = 0;
        int small = 0;
        Console.WriteLine("Enter a list of numbers, type  0 when finished\nEnter number:");
        input=int.Parse(Console.ReadLine());
        while(input!=0)
        {
            numbers.Add(input);
            Console.WriteLine("Enter number:");
            input=int.Parse(Console.ReadLine());
        }
        numbers.Sort();
        foreach(int i in numbers)
        {
            sum+=i;
            if(i>big)
            {
                big=i;
            }
            if(i>0&&(small==0||i<small))
            {
                    small=i;
            }
        }
        average=(sum*1.0)/numbers.Count();
        Console.WriteLine($"The sum is: {sum}\nThe average is: {average}\nThe largest number is: {big}\nThe smallest positive number is: {small}\n The sorted list is: ");
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}