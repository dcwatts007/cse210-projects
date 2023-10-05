public class Resume 
{
    public String Name { get; set; }
    public List<Job> Jobs { get; set; }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}\nJobs:");
        foreach (Job j in Jobs)
        {
            j.Display();
        }
    }
}