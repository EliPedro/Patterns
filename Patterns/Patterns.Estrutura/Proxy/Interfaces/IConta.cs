using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Estrutura.Proxy.Interfaces
{
    public interface IConta
    {
        void Depositar(double valor);

        void Sacar(double valor);

        double ObterSaldo();
    }
}