using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>();
        Journal journal = new Journal();
        int option = journal.DisplayMenu();
        while (option != 7)
        {
            if (option == 1)
            {
                Console.WriteLine("What should the new journal be called? (follow the file name with .txt)");
                journal.File=Console.ReadLine();
            }else if(option==2||option==6)
            {
                Console.WriteLine("What is the file name?");
                journal.LoadJournal(Console.ReadLine());
            }else if(option==3)
            {
                journal.SaveJournal();
            }else if(option==4)
            {
                Console.WriteLine("What would you like to call your new journal?(end the name of your journal with .txt)");
                journal.SaveJournalAs(Console.ReadLine());
            }else if(option==5)
            {
                Entry entry = new Entry();
                entry.Prompt(prompts);
                entry.SaveToJournal(journal);
            }else if(option==8)
            {
                journal.DisplayJournal();
            }
            else if(option!=7)
            {
                Console.WriteLine("please enter a valid number");
            }

        }

    }
}