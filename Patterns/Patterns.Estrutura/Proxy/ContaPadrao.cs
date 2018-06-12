using Patterns.Estrutura.Proxy.Interfaces;
using System;

namespace Patterns.Estrutura.Proxy
{
    public class ContaPadrao : IConta
    {
        private double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public double ObterSaldo()
        {
            return this.saldo;
        }

        public void Sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}