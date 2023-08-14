using Easyware.Lib2.Extensions;

class Program
{
    static void Main(string[] args)
    {
        var text = "CSharp   Unitiy IOS,Android,Tizen,Windows,OS/2";
       
        Console.WriteLine(text.WordCount(",/ ")+" kelime");
    }
}
