namespace Patterns.Estrutura.Facade
{
    public class PedidoFacade
    {
        public Estoque Estoque { get; private set; }
        public Financeiro Financeiro { get; private set; }
        public PosVenda PosVenda { get; private set; }

        public PedidoFacade(Estoque estoque, Financeiro financeiro, PosVenda posVenda)
        {
            Estoque = estoque;
            Financeiro = financeiro;
            PosVenda = posVenda;
        }

        public void RegistrarPedido(Pedido p)
        {
            Estoque.EnviarProduto(p.Produto, p.EnderecoDeEntrega);
            Financeiro.Faturar(p.Cliente, p.Produto);
            PosVenda.AgendarContato(p.Cliente, p.Produto);
        }
    }
}