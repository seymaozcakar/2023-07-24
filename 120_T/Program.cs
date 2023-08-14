///////Teranry //////////////////

class Program
{
    static void Main(string[] args)
    {
        var maas = 1000;
        var askariMaas = 5000;

        var isPrime = true;
        var stat = "";

        if (isPrime)
        {
            stat = "Asal Sayı";
        }
        else
        {
            stat = "Asal Değil";
        }

        var stat2 = (isPrime == true) ? "Asal Sayı" : "Asal Değil";

        if (maas < askariMaas)
        {
            maas = askariMaas;
        }

        maas = (maas < askariMaas) ? askariMaas : maas;

        var health = 20;
        var pulse = 50;
        Console.WriteLine("health = " + health);
        Console.WriteLine("Pulse  = " + pulse);

        health = (health - pulse < 0) ? 0 : health - pulse;

        Console.WriteLine("health = " + health);
    }
}
