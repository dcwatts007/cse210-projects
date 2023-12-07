using System.Text.Json.Serialization;
[JsonDerivedType(typeof(Goals),typeDiscriminator: "Checklist")]
class Checklist : Goals
{
    public int Max { get; set; }
    public int Current { get; set; }
    public Checklist(int value, int max)
    {
        Type="Checklist";
        Max=max;
        Value=value;
        Complete=false;
        Current=0;
    }
    public Checklist()
    {

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