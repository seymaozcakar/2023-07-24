

using Easyware.Lib.ConsoleApp;

class Program
{
    static int KareAlaniHesapla(int kenar)
    {
        if (kenar < 1)
        {
            throw new Exception("Kenar 1m'den kısa olamaz!"); //throw(fırlatmak)
        }

        return kenar * kenar;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(KareAlaniHesapla(-10) + "m2");
        }
        catch (Exception ex)
        {
            Ekran.CizgiCiz();
            Console.WriteLine(ex.Message);
        }
    }
}
