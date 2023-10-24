public class Assignment
{
    public String StudentName { get; set; }
    public String Topic { get; set; }
    public string GetSummary()
    {
        return StudentName+" - "+Topic;
    }
}