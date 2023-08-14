using Easyware.Lib.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        var str = "abc";
        Console.WriteLine(str);
        try //try bloğunda minimum kod olmalıdır.
        {
            var sayi = int.Parse(str);
            Console.WriteLine(sayi * 2);
        }
        catch (Exception ex)
        {

            Console.WriteLine("Hata!");
            Console.WriteLine("Message = "+ex.Message);
            Console.WriteLine();
            Console.WriteLine("Source = "+ex.Source);
            Console.WriteLine();
            Console.WriteLine("StackTrace = "+ex.StackTrace);
        }
        finally 
        {
            Ekran.CizgiCiz();
            Console.WriteLine("İşlem Bitti"); 
        }
    }
}
