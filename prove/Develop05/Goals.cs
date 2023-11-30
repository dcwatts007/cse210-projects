abstract class Goals
{
    public static int Value { get; set; }
    public string Goal { get; set; }
    public bool Complete { get; set; }
    public abstract int Record();
}