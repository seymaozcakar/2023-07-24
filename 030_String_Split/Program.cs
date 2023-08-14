class Program
{
    static void Main(string[] args)
    {
        var cumle = "Bizi  çalışmak   kurtarır";
        Console.WriteLine(cumle);

        var kelimeler = cumle.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int row = 1;
        foreach (var kelime in kelimeler)
        {
            Console.WriteLine(row++ + "." + kelime);
        }
    }
}
