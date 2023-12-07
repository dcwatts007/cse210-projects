using System.Text.Json.Serialization;

[JsonDerivedType(typeof(Goals),typeDiscriminator: "Eternal")]
class Eternal : Goals
{
    public bool JsonIDEternal { get; set; }
    public Eternal(int value)
    {
        JsonIDEternal=true;
        Type="Eternal";
        Value=value;
        Complete = false;
    }
    public Eternal()
    {
        
    }
    public override int Record()
    {
        return Value;
    }
}