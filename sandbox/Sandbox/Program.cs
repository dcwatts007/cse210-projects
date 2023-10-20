using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string ans = "";
        string str = "platypus";
        for(int i = str.Count();i>0;i--)
        {
            ans+=str.Substring(i-1,1);
        }
        Console.WriteLine(ans);
    }
}