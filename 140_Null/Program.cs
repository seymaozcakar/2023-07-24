using Easyware.Lib.ConsoleApp;

class Ornek
{
    public int Birsayi { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Nullable<int> sayi1=5;
        int? sayi2 = 5; //iki yazım da aynı şeyi ifade ediyor.

        if (sayi1.HasValue)
        Console.WriteLine(sayi1);
        else 
        Console.WriteLine("boş");

        Ekran.CizgiCiz();

        if (sayi2 != null)
        {
            Console.WriteLine(sayi2.Value);
            Console.WriteLine(sayi2);
        }

        Ekran.CizgiCiz();

        DateTime? tarih=DateTime.Now;

        if (tarih.HasValue)
        {
            Console.WriteLine(tarih.Value);
        }
        else
        {
            Console.WriteLine("Tarih yok");
        }


        

    }
}
