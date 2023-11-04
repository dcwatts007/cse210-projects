using System;
class Listing : Activity
{
    public static List<string> Questions = new List<string>{"Who are people you appreciate?","WHat are personal strengths you posses?","When have you felt the Holy Ghost?","What are some of the blessings God has given you recently?","How have you seen the hand of God reaching out to touch you or your fellow man?"};
    public static void AddQuestion(string prompt)
    {
        Questions.Add(prompt);
    }
    public void DoIt()
    {
        Console.WriteLine("Welcome to the listing activity!\n his activingy will help you reflect on the good things in your life by having you list them.\nHow long would you like to do this activity.");
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
        Random rand = new Random();
        Console.WriteLine(Questions[rand.Next(0, Questions.Count())]);
        for(int i=0;i<10;i++)
        {
            Console.Write(i);
            Loading(1);
            Console.Write("\b");
        }
        int counter = 0;
        while (Timer(time))
        {
            Console.ReadLine();
            counter++;
        }
        Console.WriteLine("You listed "+counter+"items");
        FinalPrompt();
    }
}