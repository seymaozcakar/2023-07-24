////////Plaka
using Easyware.Lib.ConsoleApp;
using Easyware.Lib2.Extensions;   

class PlakaYonetim
{
    private Dictionary<int, string> plakalar = new Dictionary<int, string>();
    public bool TryEkle(string plaka, string sehir)
    {
        if (!int.TryParse(plaka, out int plakaNo))
        {
            Console.WriteLine("plaka sayı olmalı");
            return false;
        }
        if (sehir.IsNumber())
        {
            Console.WriteLine("Sehir sayı olamaz!");
            return false;
        }

        if (plakalar.ContainsKey(plakaNo))
        {
            Console.WriteLine(plaka + " - plaka zaten var");
            return false;
        }
        if (plakalar.ContainsValue(sehir))
        {
            Console.WriteLine(sehir + " - zaten var");
            return false;
        }

        plakalar.Add(plakaNo, sehir);
        return true;
    }
    public void Listele()
    {
        Ekran.BaslikYaz("Plakalar");

        int satir = 1;
        foreach (var key in plakalar.Keys)
        {
            Console.WriteLine($"{satir++}. {key} - {plakalar[key]}");
        }
    }
    public PlakaYonetim()
    {
        plakalar.Add(10, "Balıkesir");
        plakalar.Add(34, "İstanbul");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PlakaYonetim plakaYonetim = new PlakaYonetim();
        plakaYonetim.Listele();
        while (true)
        {
            var plaka = Ekran.Oku("Plaka Numarası");
            var sehir = Ekran.Oku("Şehir Adı     ");
            if (!plakaYonetim.TryEkle(plaka, sehir))
            {
                Console.WriteLine();
                Console.WriteLine("Hatalı giriş");
                Ekran.CizgiCiz();
                Console.WriteLine();
                continue;
            }
            Console.Clear();
            plakaYonetim.Listele();

        }
    }
}
