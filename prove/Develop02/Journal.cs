using System;
public class Journal
{
    public List<Entry> Entries { get; set; }
    public string File { get; set; }
    public Journal()
    {
        Entries = new List<Entry>();
        File = "";
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"Date:{entry.Date}\nPrompt:{entry.PromptUsed}\n{entry.Response}\n\n");
        }
    }
    public void SaveJournal()
    {
        using System.IO.StreamWriter saver = new System.IO.StreamWriter(File);
        {
            foreach (Entry entry in Entries)
            {
                saver.WriteLine(entry.Date);
                saver.WriteLine(entry.PromptUsed);
                saver.WriteLine(entry.Response);
            }
        }
    }
    public void SaveJournalAs(string file)
    {
        File = file;
        using (System.IO.StreamWriter saver = new System.IO.StreamWriter(File))
        {
            foreach (Entry entry in Entries)
            {
                saver.WriteLine(entry.Date);
                saver.WriteLine(entry.PromptUsed);
                saver.WriteLine(entry.Response);
            }
        }
    }
    public void LoadJournal(string file)
    {
        File = file;
        2string[] entries = System.IO.File.ReadAllLines(file);
        Entries.Clear();
        for (int i = 0; i < entries.Length; i += 3)
        {
            Entry entry = new Entry();
            entry.Date = entries[i];
            entry.PromptUsed = entries[i + 1];
            entry.Response = entries[i + 2];
            Entries.Add(entry);
        }
    }
    public int DisplayMenu()
    {
        int option = 0;
        if (File == "")
        {
            Console.WriteLine("To start new journal, press 1.\n to load an old jounal press 2\nTo exit program, press 7.");
            option = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("To save journal, press 1\n To save journal to a new file, press 2,\n To start a new entry, press 3\n to load a new journal, press 4\nto exit program, press 5\nTo display journal press 6.");
            option = int.Parse(Console.ReadLine()) + 2;
        }
        return (option);
    }
}