class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(06, "Ankara");
        dic.Add(10, "Balıkesir");
        dic.Add(34, "İstanbul");

        ShowDic(dic);

        int plaka = 0;
        bool Basarili = false;
        do
        {
            Console.WriteLine("Eklemek istediğiniz şehrin plaka kodunu giriniz");
            string GirilenPlaka = Console.ReadLine();
            Basarili = int.TryParse(GirilenPlaka, out plaka);
            if (!Basarili)
            {
                Console.WriteLine("Yanlış giriş yaptınız.");
            }

        } while (!Basarili);
        Console.WriteLine("Plaka kodu eklendi ");

        dic.Add(16, "Bursa");
        ShowDic(dic);
