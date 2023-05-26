namespace Exercício_1;
class Homem:Animal
{
    public override string fala()
    {
        return base.fala() + "Oii";
    }
}