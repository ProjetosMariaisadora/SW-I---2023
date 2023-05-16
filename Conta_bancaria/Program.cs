namespace Conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta();

        conta.nomeCliente ="Maria ";
        conta.numeroConta = 123;
        conta.limite = 1000;
        conta.saldo = 5000;

        conta.depositar(200);

        conta.sacar(50);

       double saldo = conta.ConsultaSaldo();

       //para vizualisar
       Console.WriteLine("O seu saldo é de: " + saldo);

    }
}
