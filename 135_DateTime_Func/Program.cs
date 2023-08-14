///datetime
using Easyware.Lib.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        DateTime tarih = DateTime.Now;
        Console.WriteLine(tarih.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine(tarih.Year);
        Console.WriteLine(tarih.Month);
        Console.WriteLine(tarih.Day);
        Ekran.CizgiCiz();
        tarih = tarih.AddDays(10);
        Console.WriteLine(tarih.ToString("yyyy-MM-dd HH:mm:ss"));
        tarih = tarih.AddMonths(-300).AddYears(10).AddMinutes(2000);
        Console.WriteLine(tarih.ToString("yyyy-MM-dd HH:mm:ss"));
    }

    private static void DateFormat()
    {
        DateTime tarih = DateTime.Now;
        Console.WriteLine(tarih);
        Console.WriteLine(tarih.ToString());
        Console.WriteLine("ToLongDateString = " + tarih.ToLongDateString());
        Console.WriteLine("ToLongTimeString = " + tarih.ToLongTimeString());
        Ekran.CizgiCiz();
        Console.WriteLine("ToShortDateString = " + tarih.ToShortDateString());
        Console.WriteLine("ToShortTimeString = " + tarih.ToShortTimeString());
        Ekran.CizgiCiz();
        Console.WriteLine(tarih.ToString("O"));
        Console.WriteLine(tarih.ToString("d"));
        Ekran.CizgiCiz();
        Console.WriteLine(tarih.ToString("yy-MM"));
        Console.WriteLine(tarih.ToString("yyyy-MMM"));
        Console.WriteLine(tarih.ToString("yyyy-MMMM"));
        Console.WriteLine(tarih.ToString("yyyy-MM-dd"));
        Console.WriteLine(tarih.ToString("yyyy.MM.dd HH:mm:ss fffff"));
    }
}
