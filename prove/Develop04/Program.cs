using System;
class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        int answer = activity.DisplayMenu();
        while (answer != 5)
        {
            if (answer == 0)
            {
                Console.WriteLine("Invalid Response.");
            }
            else if (answer == 1)
            {
                Breathing breathing = new Breathing();
                breathing.Doit();
            }
            else if (answer == 2)
            {
                Listing listing = new Listing();
                listing.DoIt();
            }
            else if (answer == 3)
            {
                Reflection reflection = new Reflection();
                reflection.DoIt();
            }
            else if (answer == 4)
            {
                Console.WriteLine("To add a list prompt, press 1\nTo add an expierience prompt, press 2\nTo add a question about your expieriences, press 3\nPress any other key to cancel.");
                int prompt = 0;
                try
                {
                    prompt = int.Parse(Console.ReadLine());
                    if (prompt == 1)
                    {
                        Console.WriteLine("What things would you like to be able to list?");
                        Listing.AddQuestion(Console.ReadLine());
                    }
                    else if (prompt == 2)
                    {
                        Console.WriteLine("What expieriences would you like to be able to reflect on?");
                        Reflection.AddExpiieriencePromt(Console.ReadLine());
                    }
                    else if (prompt == 3)
                    {
                        Console.WriteLine("What would you like us to ask you about in your reflection activities?");
                        Reflection.AddQuestion(Console.ReadLine());
                    }
                }
                catch { }
            }
            answer = activity.DisplayMenu();
        }
    }
}