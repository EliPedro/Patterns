using Patterns.Estrutura.Adapter.Interfaces;
using System;

namespace Patterns.Estrutura.Adapter
{
    public class ControleDePontoNovo : IControleDePontoNovo
    {
        public void Registrar(Empregado f, bool entrada)
        {
            if (entrada)
            {
                Console.WriteLine("Entrada : " + f.Nome + " às " + DateTime.Now);
                return;
            }

            Console.WriteLine("Saída : " + f.Nome + " às " + DateTime.Now);
        }
    }
}