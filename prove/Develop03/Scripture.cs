using System.Diagnostics.Metrics;
using System.Net.Mime;
using System.Reflection.Emit;

public class Scripture
{
    public Verse Content { get; set; }= new Verse("");
    public String Reference { get; set; }    public Scripture(string content, string reference)
    {
          Verse holder = new Verse(content);
          Content.Words=holder.Words;
          Content.Shown=holder.Shown;
          Reference = reference;
    }
    public void Memorize()
    {
        while(Content.Shown.Count!=0)
        {
            int counter = 0;
            foreach(int i in Content.Shown)
            {
                while(counter!=i)
                {
                    Console.Write(" ____ ");
                    counter++;
                }
                Console.Write(Content.Words[i]);
                counter++;
            }
            Console.WriteLine("\n How many words would you like to erase?(type quit to quit)");
            String response=Console.ReadLine();
            if(response.ToLower()=="quit")
            {
                break;
            }
            try{
                Content.Erase(int.Parse(response));
                Console.Clear();
            }catch{
                Content.Erase();
                Console.Clear();
            }
        }
    }
}