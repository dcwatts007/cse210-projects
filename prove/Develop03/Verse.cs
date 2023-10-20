using System.Security.Principal;

public class Verse
{
    public List<string> Words { get; set; }
    public List<int> Shown { get; set; }
    public Verse(string verse)
    {
        String holder = "";
        Shown=new List<int>();
        Words = new List<string>();
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
        for(int i=0;i<Words.Count();i++)
        {
            Shown.Add(i);
        }
    }
    public void Erase(int num)
    {
        for(int i=0;i<num;i++)
        {
            Random ran = new Random();
            if(Shown.Count!=0)
            Shown.RemoveAt(ran.Next(0,Shown.Count()-1));
        }
    }
    public void Erase()
    {
        Random ran = new Random();
        Erase(ran.Next(1,Shown.Count()));
    }
}