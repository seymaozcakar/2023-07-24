///Null_Check
using Easyware.Lib.ConsoleApp;

class Kisi
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string TamAdi => Adi + " " + Soyadi.ToUpper();

    public Kisi Annesi { get; set; }

    public string AnneAdi
    {
        get
        {
            return Annesi.TamAdi;
        }
    }
    public void Hakkinda()
    {
        Console.WriteLine(TamAdi);
        var anne = this.Annesi;
        if (anne != null)
        {
            Console.WriteLine("Anne = " + anne.TamAdi);
        }
        else
        {
            Console.WriteLine("Anne = ----");
        }
    }
    public void Hakkinda2()
    {
        Console.WriteLine(TamAdi);
        var anne = this.Annesi;
        Console.WriteLine("Anne = " + anne?.TamAdi);
    }
    public void Hakkinda3()
    {
        Console.WriteLine(TamAdi);
        Kisi kisi = this.Annesi;
        do
        {
            Console.WriteLine("Anne = " + kisi?.TamAdi);
            kisi = kisi.Annesi;
        } while (kisi != null);


    }
}
class Program
{
    static void Main(string[] args)
    {
        Kisi kisi1 = new Kisi { Adi = "İsmail", Soyadi = "Türkmen" };
        Kisi kisi2 = new Kisi { Adi = "Gülsüm", Soyadi = "Türkmen" };
        Kisi kisi3 = new Kisi { Adi = "Fatma", Soyadi = "Türkmen" };

        kisi1.Annesi = kisi2;
        kisi2.Annesi = kisi3;

        kisi1.Hakkinda3();
        Ekran.CizgiCiz();

        kisi2.Hakkinda2();
        Ekran.CizgiCiz();

        kisi3.Hakkinda2();
        Ekran.CizgiCiz();


    }
}
