class Breathing : Activity
{
    public void Doit()
    {
        Console.WriteLine("Welcome to the Breathing Activity.\nThis activity will help you relax by slowly breathing in and out.\nHow long would you like to do this exercise?");
        DateTime? time=null;
        while (!(time is DateTime))
        {
            try
            {
                time = DateTime.Now.AddSeconds(int.Parse(Console.ReadLine()) + 2);
            }
            catch
            {
                Console.WriteLine("Invalid response, enter a whole number.");
            }
        }
        StartPrompt();
        
        while (Timer(time))
        {
            Console.WriteLine("Breath In for 5");
            for(int i=4;i>0;i--)
            {
                Loading(1);
                Console.Write("\b"+i);
            }
            Loading(1);
            Console.WriteLine("\nBreath Out for 5");
            for(int i=4;i>0;i--)
            {
                Loading(1);
                Console.Write("\b"+i);
            }
            Loading(1);
        }
        FinalPrompt();
    }
}