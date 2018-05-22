using System;

namespace Patterns.Estrutura.Facade
{
    public class PosVenda
    {
        public void AgendarContato(String cliente, String produto)
        {
            Console.WriteLine(" Entrar em contato com " + cliente
            + " sobre o produto " + produto + " no dia " + DateTime.Now.AddDays(30));
        }
    }
}