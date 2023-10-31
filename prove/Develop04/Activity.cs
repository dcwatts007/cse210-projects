class Activity
{
    public static bool Timer(int time)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(time);
        return(start<end);
    }   
    public static int DisplayMenu()
    {
        Console.WriteLine("What would you like to do?\nFor a Breathing exercise, press 1.\nFor a Listing exercise, press 2.\nFor a Refletion exercise, press 3.\nTo quit, press 4.");
        try
        { 
            int answer = int.Parse(Console.ReadLine());
            if(answer>0&&answer<5){
                return answer;
            }else
            {
                return 0;
            }
        }catch
        {       
            return 0;
        }
    }
    public static int FinalPrompt()
    {
        Console.WriteLine("Well done!");
        Thread.Sleep(3000);
        return DisplayMenu();
    }
    public static void StartPrompt()
    {
        Console.WriteLine("Get ready...");
        Console.Write("-");
        for(int i=0;i<5;i++)
        {
            Thread.Sleep(100);
            Console.Write("\b\\");
            Thread.Sleep(100);
            Console.Write("\b|");
            Thread.Sleep(100);
            Console.Write("\b/");
            Thread.Sleep(100);
            Console.Write("\b-");
        }
    }
}