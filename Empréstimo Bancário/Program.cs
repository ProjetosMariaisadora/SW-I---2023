﻿namespace Empréstimo;
class Program
{
    static void Main(string[] args)
    {
        Banco b = new Banco();

        b.Depositar(1000);
        b.Sacar(1600);
        b.AjustarLimite(500);

        double valortotal = b.MostrarSaldo();

        Console.WriteLine("O saldo da sua conta é de " + valortotal);
        
        b.imprimi(b.emprestimo(12,1000));
    }
}
