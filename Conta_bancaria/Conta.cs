namespace Conta_bancaria;
class Conta
{
    public string? nomeCliente{get;set;}
    public int numeroConta{get;set;}
    public double saldo {get;set;}
    public double limite{get;set;}

    //MÉTODO PARA REALIZAR UM DEPÓSITO
     public void depositar (double valor){
        this.saldo += valor;
     }

    //MÉTODO ConsultaSaldo - retorna um disponível + limite

    public double ConsultaSaldo (){
       return this.saldo + this.limite;
    }
    //MÉTODO para realizar um saque
    public void sacar (double valor){
        this.saldo -= valor;
    }
}
