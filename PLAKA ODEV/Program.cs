////////Plaka
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(6, "Ankara");
        dic.Add(16, "Bursa");

        foreach (int key in dic.Keys)
        {
            Console.WriteLine($"{key} - {dic[key]}");
        }
        do
        {
            Console.WriteLine();
            Console.Write("Plaka giriniz: ");

            int plaka;
            int plakaKontrol;
            bool plakaGirildi = int.TryParse(Console.ReadLine(), out plaka);


            if (!plakaGirildi)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen sayısal bir değer giriniz.");
                continue;
            }
            if (dic.ContainsKey(plaka))
            {
                Console.WriteLine();
                Console.WriteLine("Bu plaka kodu zaten kayıtlı.");
                continue;
            }

            Console.WriteLine();
            Console.Write("Şehir giriniz: ");
            string sehir = Console.ReadLine();
            sehir = sehir.Substring(0, 1).ToUpper() + sehir.Substring(1);

            int sehirSayi;
            bool sehirSayiMi = int.TryParse(sehir, out sehirSayi);

            if (sehirSayiMi)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen string bir değer giriniz.");
                continue;
            }

            if (dic.ContainsValue(sehir))
            {
                Console.WriteLine();
                Console.WriteLine("Girilen şehir zaten kayıtlı.");
                continue;
            }
            dic.Add(plaka, sehir);
            Console.WriteLine();
            Console.WriteLine($"{sehir} Eklendi");
            Console.WriteLine();

            foreach (int key in dic.Keys)
            {
                Console.WriteLine($"{key} - {dic[key]}");
            }
        } while (true);
    }
}
