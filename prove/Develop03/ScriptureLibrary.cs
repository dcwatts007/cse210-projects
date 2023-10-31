public class ScriptureLibrary
{
    public List<Scripture> Scriptures { get; set; }=new List<Scripture>();
    public ScriptureLibrary(){}
    public ScriptureLibrary(List<Scripture> scriptures)
    {
        Scriptures=scriptures;
    }
    public int DisplayMenu()
    {
        Console.WriteLine("What would you like to do?\nTo add a new scripture to your library, press 1.\nTo try to Memorize a scripture, press 2.\nTo Quiz yourself on a specific scripture, press 3\nTo quiz yourself on a random scripture, press 4.\nTo Quiz yourelf on all your scriptures, press 5.\nTo quit, press 6.");
        return int.Parse(Console.ReadLine());
    }
    public double Quiz(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine("Please type, "+scripture.Reference);
        string verse = Console.ReadLine();
        string holder="";
        double score=0.0;
        int counter=0;
        List<string> Words = new List<string>();
        for(int i=0;i<verse.Count();i++)
        {
            holder+=verse.Substring(i,1);
            if(verse.Substring(i,1).Equals(" "))
            {
                Words.Add(holder);
                holder="";
            }  
        }
        Words.Add(holder);
        if(Words.Count>scripture.Content.Words.Count){
            foreach (string str in scripture.Content.Words)
            {
                if(str==Words[counter])
                {
                    score+=1;
                }
                counter++;
            }
        }else
        {
            foreach (string str in Words)
            {
                if(str==scripture.Content.Words[counter])
                {
                    score+=1;
                }
                counter++;
            }
        }
        return(score/counter);
    }
    public void AddScripture(Scripture scripture)
    {
        Scriptures.Add(scripture);
    }
}