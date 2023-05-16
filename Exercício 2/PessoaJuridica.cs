namespace Exercício_2;
class PessoaJuridica:Contrato
{
    public string? NomeEmpresa {get;set;}
    public string? CNPJ {get;set;}
    public string? IE{get;set;}

    public override string MostraDados(){
        return base.MostraDados() + "Nome  da empresa" + this.NomeEmpresa + "CNPJ" + this.CNPJ + "IE" + this.IE;
    }
}