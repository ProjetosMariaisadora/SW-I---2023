namespace Exercício_2;
class PessoaFisica:Contrato
{
    public string? CPF{get;set;}
    public int Idade {get;set;}

    public override string MostraDados()
    {
        return base.MostraDados() + this.CPF + this.Idade;
    }
}
