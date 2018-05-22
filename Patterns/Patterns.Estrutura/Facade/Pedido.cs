using System;

namespace Patterns.Estrutura.Facade
{
    public class Pedido
    {
        public String Produto { get; private set; }
        public String Cliente { get; private set; }
        public String EnderecoDeEntrega { get; private set; }

        public Pedido(string produto, string cliente, string enderecoDeEntrega)
        {
            Produto = produto;
            Cliente = cliente;
            EnderecoDeEntrega = enderecoDeEntrega;
        }
    }
}