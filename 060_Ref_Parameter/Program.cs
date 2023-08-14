class Program //bu kullanım sağlıklıdır.
{
    static void Swap<TValue>(ref TValue value1, ref TValue value2)
    {
        TValue tmp = value1;
        value1 = value2;
        value2 = tmp;
    }

    static void Swap(ref int value1, ref int value2)
    {
        int tmp = value1;
        value1 = value2;
        value2 = tmp;
    }

    static void Swap(ref string value1, ref string value2)
    {
        string tmp = value1;
        value1 = value2;
        value2 = tmp;
    }

    static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 20;
        string isim1 = "Lizge";
        string isim2 = "Şeyma";

        Console.WriteLine("sayi1 = " + sayi1);
        Console.WriteLine("sayi2 = " + sayi2);
        Console.WriteLine("-----------------------------");

        //Swap(ref sayi1, ref sayi2);
        Swap<int>(ref sayi1, ref sayi2);

        Console.WriteLine("sayi1 = " + sayi1);
        Console.WriteLine("sayi2 = " + sayi2);
        Console.WriteLine(); Console.WriteLine();
      
        Console.WriteLine("isim1 = " + isim1);
        Console.WriteLine("isim2 = " + isim2);
        Console.WriteLine("-----------------------------");

        //Swap(ref isim1, ref isim2);
        Swap<string>(ref isim1, ref isim2);

        Console.WriteLine("isim1 = " + isim1);
        Console.WriteLine("isim2 = " + isim2);
    }
}
