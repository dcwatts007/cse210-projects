using System.Text.Json.Serialization;
[JsonDerivedType(typeof(Goals),typeDiscriminator: "Single")]
class Single:Goals
{
    public bool JsonIDSingle { get; set; }
    public Single(int value)
    {
        JsonIDSingle=true;
        Type="Single";
        Value=value;
        Complete = false;
    }
    public Single()
    {
    }
    public override int Record()
    {
        Complete=true;
        return Value;
    }
}