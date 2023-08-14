using Easyware.Lib2.Extensions;

namespace Easyware.Lib.ConsoleApp
{
    public class Ekran
    {
        public static void CizgiCiz()
        {
            Console.WriteLine("--------------------------");
        }
        public static void BaslikYaz(string baslik)
        {
            CizgiCiz();
            Console.WriteLine($" {baslik.ToUpper()}- {baslik.WordCount()}");
            CizgiCiz();
        }

        public static string Oku(string etiket)
        {
            Console.Write(etiket + " : ");
            return Console.ReadLine();
        }

        public static int SayiOku(string etiket)
        {
            int sonuc = 0;
            string girilen;
            do
            {
                girilen = Oku(etiket);
            } while (!int.TryParse(girilen, out sonuc));

            return sonuc;
        }
    }
}