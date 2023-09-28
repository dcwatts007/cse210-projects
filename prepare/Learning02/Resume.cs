public class Resume 
{
    public String Name { get; set; }
    public List<Job> jobs { get; set; }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}\nJobs:");
        foreach (Job j in jobs)
        {
            j.Display();
        }
    }
}