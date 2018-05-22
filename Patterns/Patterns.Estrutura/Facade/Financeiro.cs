using System;

namespace Patterns.Estrutura.Facade
{
    public class Financeiro
    {
        public void Faturar(String cliente, String produto)
        {
            Console.WriteLine(" Fatura :" + Guid.NewGuid().ToString());
            Console.WriteLine(" Cliente : " + cliente);
            Console.WriteLine(" Produto : " + produto);
        }
    }
}