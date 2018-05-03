using Patterns.Estrutura.Adapter.Interfaces;
using System;

namespace Patterns.Estrutura.Adapter
{
    public class ControleDePonto : IControleDePonto
    {
        public virtual void RegistrarEntrada(Empregado f)
        {
            Console.WriteLine("Entrada : " + f.Nome + " às " + DateTime.Now);
        }

        public virtual void RegistrarSainda(Empregado f)
        {
            Console.WriteLine("Saída : " + f.Nome + " às " + DateTime.Now);
        }
    }
}