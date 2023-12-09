class Card
{
    public int Value { get; set; }
    public String Suite { get; set; }
    public override String ToString()
    {
        return Value+" of "+Suite;
    }
}