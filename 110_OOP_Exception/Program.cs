//Inner EXCEPTION(Bir alttaki sebep)
using Easyware.Lib.ConsoleApp;
class Dortgen
{
    public int Kenar1 { get; set; }
    public int Kenar2 { get; set; }

    public Dortgen(int kenar1, int kenar2)
    {
        Kenar1 = kenar1;
        Kenar2 = kenar2;
    }

    public Dortgen(string kenar1, string kenar2)
    {
        try
        {
            Kenar1 = int.Parse(kenar1);
            Kenar2 = int.Parse(kenar2);
        }
        catch (Exception ex)
        {
            throw new Exception("Dortgen oluşturulamadı", ex);
        }
    }

    public void Hakinda()
    {
        Console.WriteLine("Alan= " + Kenar1 * Kenar2 + " m2 ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ekran.BaslikYaz("Dortgen Hesabi");
        var kenar1 = Ekran.Oku("Kenar1");
        var kenar2 = Ekran.Oku("Kenar2");

        try
        {
            var dortgen = new Dortgen(kenar1, kenar2);
            dortgen.Hakinda();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata");
            Ekran.CizgiCiz();
            Console.WriteLine(ex.Message);
            if (ex.InnerException != null)
            {
                Console.WriteLine("==> " + ex.InnerException.Message);
            }
            Ekran.CizgiCiz();

            var innerEx = ex.InnerException;
            while (innerEx != null)
            {
                Console.WriteLine("==> " + innerEx?.Message);
                innerEx = innerEx?.InnerException;
            }


        }
    }
}
