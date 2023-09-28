public class Job
{
    public String Company { get; set; }
    public String JobTitle {get; set;}
    public int StartYear { get; set; }
    public int EndYear{get;set;}
    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}
