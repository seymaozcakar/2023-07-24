using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var cumle = "Bizi  çalışmak   kurtarır";
        Console.WriteLine(cumle);
        var seperators = new char[] { ' ' };

        var kelimeler = cumle.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
        int row = 1;
        foreach (var kelime in kelimeler)
        {
            Console.WriteLine(row++ + "." + kelime);
        }
    }
}
