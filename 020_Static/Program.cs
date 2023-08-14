class Ekran
{
    public static void CizgiCiz()
    {
        Console.WriteLine("--------------------");
    }

    private static int MyProperty { get; set; }

}

class Program
    {
        static void Main(string[] args)
        {
            Ekran.CizgiCiz();
        }
    }
}
