class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = { 1, 2, 3, 4, 5 };

        try
        {
            Console.WriteLine(sayilar[10]);
        }
        catch   
        {

          Console.WriteLine("Hata!");
        }
        finally //catch olmadan da finally kullanabilirim.
        {
            Console.WriteLine("Bitti");
        }
    }
}
