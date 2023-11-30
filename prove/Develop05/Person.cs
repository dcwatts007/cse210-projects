using System.Net;
using System.Runtime.CompilerServices;

class Person
{
    int points;
    public List<Goals> MyGoals { get; set; }
    public Person()
    {
        MyGoals = new List<Goals> { };
        points = 0;
    }
    public void Record()
    {
        Console.WriteLine("What goal would you like to record?");
        foreach(Goals goal in MyGoals)
        {
            if(!goal.Complete)
            {
            Console.WriteLine("For "+goal.Goal+"press "+MyGoals.IndexOf(goal));
            }else
            {
                Console.WriteLine("You have completed "+goal+". Good job!");
            }
        }
        try{
             int newPoints=MyGoals[int.Parse(Console.ReadLine())].Record();
             points+=newPoints;
            Console.WriteLine("You got "+newPoints+"points!\nYou now have "+points+" points!!!");
        }catch{
            Console.WriteLine("Invalid Action");
        }
    }
    public int DisplayMenu()
    {
        int response = 10;
        Console.WriteLine("What would you like to do?\nTo Load a file, press 1\nTo save and quit, press 2\nTo create a new goal, press 3\nTo record a goal, press 4");
        while (response > 8)
        {
            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Must be a number");
            }
        }
        if(response==3)
        {
                    Console.WriteLine("What type of goal is it?\nFor Eternal press 1\nFor Checklist, press 2\nFor a simple goal press 3");
                                try
            {
                response += int.Parse(Console.ReadLine())+1;
            }
            catch
            {
                Console.WriteLine("Must be a number");
            }
        }
        return response;
    }
}