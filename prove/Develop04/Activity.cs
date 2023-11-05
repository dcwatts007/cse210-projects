class Activity
{
    public bool Timer(DateTime? end)
    {
        DateTime start = DateTime.Now;
        return (start < end);
    }
    public int DisplayMenu()
    {
        Console.WriteLine("What would you like to do?\nFor a Breathing exercise, press 1.\nFor a Listing exercise, press 2.\nFor a Refletion exercise, press 3.\nTo add your own prompts to the exercises, press 4\nTo quit, press 5.");
        try
        {
            int answer = int.Parse(Console.ReadLine());
            if (answer > 0 && answer <= 5)
            {
                return answer;
            }
            else
            {
                return 0;
            }
        }
        catch
        {
            return 0;
        }
    }
    public void FinalPrompt()
    {
        Console.WriteLine("Well done!");
        Thread.Sleep(3000);
    }
    public void Loading(int time)
    {
        Console.Write("-");
        for (int i = 0; i < time*2; i++)
        {
            Thread.Sleep(100);
            Console.Write("\b\\");
            Thread.Sleep(100);
            Console.Write("\b|");
            Thread.Sleep(100);
            Console.Write("\b/");
            Thread.Sleep(100);
            Console.Write("\b-");
            Thread.Sleep(100);
        }
    }
    public void StartPrompt()
    {
        Console.WriteLine("Get ready...");
        Loading(5);
    }
}