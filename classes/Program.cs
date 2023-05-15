namespace classes;
class Program
{
    static void Main(string[] args)
    {
        Classelampada lampada = new Classelampada();

        lampada.ligar();

        Console.WriteLine( "A lâmpada está ligada : " + lampada.estaLigada());
    }
}
