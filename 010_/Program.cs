enum Mevsim //numaralandırılmış veriler
{
    IlkBahar = 10,
    Yaz,
    Sonbahar,
    Kis
}

class Program
{
    static void Main(string[] args)
    {
        Mevsim mevsim1 = Mevsim.Kis;
        switch (mevsim1)
        {
            case Mevsim.IlkBahar:
                break;
            case Mevsim.Yaz:
                break;
            case Mevsim.Sonbahar:
                break;
            case Mevsim.Kis:
                break;
            default:
                break;
        }

        if (mevsim1 == Mevsim.Kis)
        {
            Console.WriteLine("mevsim kış");
        }
        Console.WriteLine(mevsim1);
        Console.WriteLine((int)mevsim1);
    }
}
