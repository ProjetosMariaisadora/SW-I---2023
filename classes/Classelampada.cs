namespace classes ;
class Classelampada
{
    public bool ligada;

    public double potência;

    public void ligar(){
        ligada = true;
    }
    public void desligar(){
        ligada = false;
    }

    public bool estaLigada(){
        return ligada;
    }
}
