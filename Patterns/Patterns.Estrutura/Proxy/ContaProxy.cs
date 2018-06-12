using Patterns.Estrutura.Proxy.Interfaces;
using System;

namespace Patterns.Estrutura.Proxy
{
    public class ContaProxy : IConta
    {
        private readonly IConta conta;

        public ContaProxy(IConta _conta)
        {
            conta = _conta;
        }

        public void Depositar(double valor)
        {
            Console.WriteLine("Efetuando o depósito de R$ " + valor + " ... ");
            conta.Depositar(valor);
            Console.WriteLine("Depósito de R$ " + valor + " efetuado ... ");
        }

        public double ObterSaldo()
        {
            Console.WriteLine("Verificando o saldo...");
            return this.conta.ObterSaldo();
        }

        public void Sacar(double valor)
        {
            Console.WriteLine("Efetuando o saque de R$ " + valor);
            this.conta.Sacar(valor);
            Console.WriteLine("Saque de R$ " + valor + " efetuado.");
        }
    }
}