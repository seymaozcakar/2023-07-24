using Easyware.Lib.ConsoleApp;
using Easyware.Lib2.Extensions;

class Kisi
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
}

static class KisiExtensions
{
    public static string TamAdi(this Kisi kisi)
    {
        return kisi.Adi + " " + kisi.Soyadi;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Ekran.BaslikYaz("CSharp Extensions Methods");
        Ekran.BaslikYaz("String Ex.");
        Kisi kisi = new Kisi() { Adi = " İsmail", Soyadi = "Türkmen" };
        Console.WriteLine(kisi.TamAdi());
        Ekran.CizgiCiz();
        var cumle = "aaa bbb ccc";
        Console.WriteLine(cumle.WordCount());
        Console.WriteLine(kisi.TamAdi().WordCount());
    }
}
