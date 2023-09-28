using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Value for x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Value for y: ");
        int y = int.Parse(Console.ReadLine());
        for(int i=0;i<y;i++)
        {
            x=48271*x;
            x%=Convert.ToInt32((Math.Pow(2,31)-1));
        }
        Console.WriteLine($"Result: {x}");
    }
}