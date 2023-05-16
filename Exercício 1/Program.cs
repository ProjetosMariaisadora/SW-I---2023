namespace Exercício_1;
class Program
{
    static void Main(string[] args)
    {
       Cao c = new Cao();
       Gato g = new Gato();
       Homem h = new Homem();

       Console.WriteLine("O Cachorro emite o " + c.fala());
       Console.WriteLine("O gato emite o " + g.fala());
       Console.WriteLine("O Homem emite o " + h.fala());
    }
}
