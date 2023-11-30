class Single:Goals
{
    public Single(int value)
    {
        Value=value;
        Complete = false;
    }
    public override int Record()
    {
        Complete=true;
        return Value;
    }
}