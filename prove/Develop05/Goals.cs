using System.Dynamic;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
abstract class Goals
{
    public string Type { get; set; }
    public static int Value { get; set; }
    public string Goal { get; set; }
    public bool Complete { get; set; }
    public abstract int Record();
}