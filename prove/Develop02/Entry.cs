public class Entry
{
    public string Response { get; set; }
    public string PromptUsed { get; set; }
    public string Date { get; set; }
    public void Prompt(List<string> Prompts)
    {
        Random rand = new Random();
        PromptUsed = Prompts[rand.Next(0,Prompts.Count())];
        Console.WriteLine($"{PromptUsed}");
        Date=DateTime.Now.ToShortDateString();
        Response=Console.ReadLine();
        if(Response=="new prompt")
        {
            Prompt(Prompts);
        }
    }
    public void SaveToJournal(Journal journal) => journal.Entries.Add(this);
}