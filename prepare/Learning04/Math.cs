public class Math : Assignment
{
    public string TextbookSection { get; set; }
    public string Problems { get; set; }
    public string GetHomeworkList()
    {
        return TextbookSection+" "+Problems;
    }
}