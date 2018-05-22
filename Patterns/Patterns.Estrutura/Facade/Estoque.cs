using System;

namespace Patterns.Estrutura.Facade
{
    public class Estoque
    {
        public void EnviarProduto(String produto, String enderecoDeEntrega)
        {
            Console.WriteLine(" O produto " + produto + " será entregue no endereço " + enderecoDeEntrega
                 + " até as 18h do dia " + DateTime.Now.AddDays(7));
        }
    }
}