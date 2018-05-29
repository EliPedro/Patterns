using Patterns.Aplicacao.Utilitarios.Enum;
using Patterns.Criacao.AbstractFactory;
using Patterns.Criacao.Build.Boletos;
using Patterns.Criacao.Builder.Boletos;
using Patterns.Criacao.FactoryMethod;
using Patterns.Criacao.Multiton.Temas;
using Patterns.Criacao.Multiton.Utilitarios;
using Patterns.Criacao.ObjectPool;
using Patterns.Criacao.Prototype.Campanhas;
using Patterns.Criacao.Singleton.Configuracoes;
using Patterns.Criacao.Singleton.Utilitarios;
using Patterns.Estrutura.Adapter;
using Patterns.Estrutura.Bridge;
using Patterns.Estrutura.Bridge.Interfaces;
using Patterns.Estrutura.Composite;
using Patterns.Estrutura.Decorator;
using Patterns.Estrutura.Facade;
using Patterns.Estrutura.Flyweight;
using Patterns.Estrutura.Flyweight.Enum;
using Patterns.Estrutura.Flyweight.Factory;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestarFlyweight();
            Console.ReadKey();
        }

        private static void TestarFlyweight()
        {
            Apresentacao a = new Apresentacao();

            a.AdicionaSlide(new Slide(TemaFlyweightFactory.ObterTema<TemaSharp>(TemaFlyweightEnum.SHARP),
            " Orientação a Objetos em Java ",
            " Com este curso você vai obter uma base \n"
            + " sólida de conhecimentos de Java \n"
            + "e de Orientação a Objetos ."));

            a.AdicionaSlide(new Slide(TemaFlyweightFactory
           .ObterTema<TemaAsterisco>(TemaFlyweightEnum.ASTERISCO),
            " Desenvolvimento Web com JSF2 e JPA2 ",
            " Depois deste curso , você estará apto a\n"
            + " desenvolver aplicações Web com \n"
            + "os padrões da plataforma Java ."));

            a.AdicionaSlide(new Slide(TemaFlyweightFactory
           .ObterTema<TemaHifen>(TemaFlyweightEnum.HIFEN),
            " Persistência com JPA2 e Hibernate ",
            " Neste curso de Java Avançado , abordamos de\n"
            + " maneira profunda os recursos de persistência \n"
            + "do JPA2 e do Hibernate ."));

            a.Imprime();
        }

        #region Teste Patterns

        private static void TestarFactoryMethod()
        {
            new FactoryEmissor().Create(TipoEmissor.Email).EnviarMensagem();
        }

        private async static Task TestarFactoryMethodAsync()
        {
            await new FactoryEmissor().CreateAsync(TipoEmissor.SMS).Result.EnviarMensagemAsync();
        }

        private static void TestarPedidoFacade()
        {
            var estoque = new Estoque();
            var financeiro = new Financeiro();
            var posVenda = new PosVenda();
            var pedido = new Pedido("Notebook ", "Desenvolvedor.Net", "Av.Brigadeiro Faria Lima , 100 , São Paulo , SP");
            var facade = new PedidoFacade(estoque, financeiro, posVenda);

            facade.RegistrarPedido(pedido);
        }

        private static void TestarDecorator()
        {
            var mensagem = "What is Lorem Ipsum ?";

            var emissorCript = new EmissorDecoratorComCriptografia(new EmissorBasico());
            emissorCript.Envia(mensagem);

            Console.WriteLine();

            var emissorCompr = new EmissorDecoratorComCompressao(new EmissorBasico());
            emissorCompr.Envia(mensagem);

            Console.WriteLine();

            var emissorCriptCompr = new EmissorDecoratorComCompressao(new EmissorDecoratorComCriptografia(new EmissorBasico()));
            emissorCriptCompr.Envia(mensagem);
        }

        private static void TesteComposite()
        {
            var trecho1 = new TrechoAndando("Vá até o cruzamento da Av. Rebouças com a Av. Brigadeiro Faria Lima ", 500);
            var trecho2 = new TrechoDeCarro("Vá até o cruzamento da Av. Brigadeiro Faria Lima com a Av. Cidade Jardim ", 1500);
            var trecho3 = new TrechoDeCarro("Vire a direita na Marginal Pinheiros ", 500);

            var caminho1 = new Caminho();
            caminho1.Adicionar(trecho1);
            caminho1.Adicionar(trecho2);

            Console.WriteLine(" Caminho 1 : ");
            caminho1.Imprimir();

            var caminho2 = new Caminho();
            caminho2.Adicionar(caminho1);
            caminho2.Adicionar(trecho3);
            Console.WriteLine(" ---------------");
            Console.WriteLine(" Caminho 2: ");
            caminho2.Imprimir();
        }

        private static void TestarBridge()
        {
            IGeradorDeArquivo geradorDeArquivoTXT = new GeradorDeArquivoTXT();
            IDocumento recibo = new Recibo("XPTO", "Teste", 1000M, geradorDeArquivoTXT);
            recibo.GerarArquivo();
        }

        private static void TestarAdapter()
        {
            var controleAdapter = new ControleDePontoAdapter(new ControleDePontoNovo());
            controleAdapter.RegistrarEntrada(new Empregado("Teste"));
            Thread.Sleep(400);
            controleAdapter.RegistrarSainda(new Empregado("Teste"));
        }

        public static void TestarObjectPool()
        {
            var funcionarios = new List<Funcionario>();
            var pool = new FuncionarioPool();

            for (int i = 0; i < 10; ++i)
            {
                funcionarios.Add(new Funcionario($"Nome - {i}"));
            }

            pool.Release(funcionarios);
            var func = pool.Acquire();

            while (func != null)
            {
                Console.WriteLine(func);
                func = pool.Acquire();
            }

            Console.WriteLine();
        }

        private static void TestarMultiton()
        {
            var fire = Tema.ObterTema(TemasEnum.Fire);
            var sky = Tema.ObterTema(TemasEnum.Sky);

            Console.WriteLine();
            Console.WriteLine(fire.Nome);
            Console.WriteLine(fire.CorDaFonte);
            Console.WriteLine(fire.CorDoFundo);
            Console.WriteLine();

            Console.WriteLine(sky.Nome);
            Console.WriteLine(sky.CorDaFonte);
            Console.WriteLine(sky.CorDoFundo);
        }

        private static void TestarSingleton()
        {
            Console.WriteLine(Configuracao.GetInstance().ObterPropriedade(PropriedadesEnum.TimeZone));
            Console.WriteLine(Configuracao.GetInstance().ObterPropriedade(PropriedadesEnum.CurrencyCode));
            Console.WriteLine(Configuracao.GetInstance() == Configuracao.GetInstance());
        }

        private static void TestarPrototype()
        {
            Console.WriteLine(new Campanha("Teste", DateTime.Now.AddDays(10), Guid.NewGuid()));
            Console.WriteLine(new Campanha("Teste", DateTime.Now.AddDays(10), Guid.NewGuid()).Clone());
        }

        private static void TestarBuilder()
        {
            var geradorBoleto = new GeradorBoleto(new BBBoletoBuilder());
            Console.WriteLine(geradorBoleto.GerarBoleto());
        }

        private static void TestarAbstractFactory()
        {
            var comunicador = new ComunicadorFactoryMasterCard(new EmissorCreator());
            var emissor = comunicador.CreateEmissor();
            emissor.Mensagem();
        }

        #endregion Teste Patterns
    }
}