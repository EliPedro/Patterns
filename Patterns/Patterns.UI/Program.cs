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
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patterns.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestarObjectPool();
            Console.ReadKey();
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

        #region

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

        #endregion

        #region Factory Method

        private static void TestarFactoryMethod()
        {
            new FactoryEmissor().Create(TipoEmissor.Email).EnviarMensagem();
        }

        private async static Task TestarFactoryMethodAsync()
        {
            await new FactoryEmissor().CreateAsync(TipoEmissor.SMS).Result.EnviarMensagemAsync();
        }

        #endregion
    }
}