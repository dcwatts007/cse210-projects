class Eternal : Goals
{
    
    public Eternal(int value)
    {
        Value=value;
        Complete = false;
    }
    public override int Record()
    {
        return Value;
    }
}