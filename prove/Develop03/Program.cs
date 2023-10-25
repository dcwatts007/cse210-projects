using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Console.WriteLine("What is the referance for a scripture you would like to memorize?");
        string book = Console.ReadLine();
        Console.WriteLine("Please paste the text of the scripture you would like to memorize.");
        string script = Console.ReadLine();
        Scripture scripture = new Scripture(script, book);
        scriptureLibrary.AddScripture(scripture);
        Console.Clear();
        while (true)
        {
            try
            {
                int answer = scriptureLibrary.DisplayMenu();
                if (answer == 1)
                {
                    Console.WriteLine("What is the referance for a scripture you would like to memorize?");
                    book = Console.ReadLine();
                    Console.WriteLine("Please paste the text of the scripture you would like to memorize.");
                    script = Console.ReadLine();
                    scripture = new Scripture(script, book);
                    scriptureLibrary.AddScripture(scripture);
                }
                else if (answer == 2)
                {
                    if (scriptureLibrary.Scriptures.Count == 1)
                    {
                        scriptureLibrary.Scriptures[0].Memorize();
                    }
                    else
                    {
                        Console.WriteLine("Which scripture would you like to memorize?");
                        int counter = 0;
                        foreach (Scripture scripture1 in scriptureLibrary.Scriptures)
                        {
                            Console.WriteLine("For " + scripture1.Reference + "type " + counter);
                            counter++;
                        }
                        scriptureLibrary.Scriptures[int.Parse(Console.ReadLine())].Memorize();
                    }
                }
                else if (answer == 3)
                {

                    Console.WriteLine("Which scripture would you like to be quized on?");
                    int counter = 0;
                    foreach (Scripture scripture1 in scriptureLibrary.Scriptures)
                    {
                        Console.WriteLine("For " + scripture1.Reference + "type " + counter);
                        counter++;
                        double score = scriptureLibrary.Quiz(scriptureLibrary.Scriptures[int.Parse(Console.ReadLine())]);
                        Console.WriteLine("You scored " + score * 100 + "% on your scripture memorization!");
                    }
                }
                else if (answer == 4)
                {
                    Random rand = new Random();
                    double score = scriptureLibrary.Quiz(scriptureLibrary.Scriptures[rand.Next(0, scriptureLibrary.Scriptures.Count)]);
                    Console.WriteLine("You have " + Math.Round(score * 100) + "% of this scripture memorized.");
                }
                else if (answer == 5)
                {
                    double score = 0;
                    foreach (Scripture scripture1 in scriptureLibrary.Scriptures)
                    {
                        score += scriptureLibrary.Quiz(scripture1);
                    }
                    score /= scriptureLibrary.Scriptures.Count;
                    Console.WriteLine("You have " + Math.Round(score * 100) + "% of your scripture library memorized.");
                }
                else if (answer == 6)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("invalid response.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Response");
            }
        }
    }
}