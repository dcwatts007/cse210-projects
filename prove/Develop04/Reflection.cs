using System;
class Refelction : Activity
{
    public static List<string> ExpieriencePrompts=new List<string> {"Think of a time you acted selflessly.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time you felt the spirit."};
    public static List<string> Questions = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you feel after your expierience?","What could you learn from your experience?","Whad did you learn about yourself through this expierence?","How will this experience change what you do in the future","What would you do if you could go through this experience again?"};
    public static void AddQuestion(string prompt)
    {
        Questions.Add(prompt);
    }
    public static void AddExpiieriencePromt(string promt)
    {
        ExpieriencePrompts.Add(promt);
    }
    public void DoIt()
    {
        Console.WriteLine("Welcome to the reflection activity!\n How long would you like to do this activity.");
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
        Console.WriteLine(ExpieriencePrompts[rand.Next(0, ExpieriencePrompts.Count())]);
        Loading();
        while (Timer(time))
        {
            Console.WriteLine(Questions[rand.Next(0, Questions.Count())]);
            Loading();
        }
        FinalPrompt();
    }
}