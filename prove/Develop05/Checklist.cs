class Checklist : Goals
{
    public int Max { get; set; }
    public int Current { get; set; }
    public Checklist(int value, int max)
    {
        Max=max;
        Value=value;
        Complete=false;
        Current=0;
    }
    public override int Record()
    {
        Current++;
        if(Current==Max)
            {
                Complete = true;
                Value+=500;
            }
        return Value;
    }
}