using Patterns.Aplicacao.Utilitarios.Enum;
using Patterns.Criacao.AbstractFactory;
using Patterns.Criacao.Build.Boletos;
using Patterns.Criacao.Builder.Boletos;
using Patterns.Criacao.FactoryMethod;
using System;
using System.Threading.Tasks;

namespace Patterns.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestarBuilder();
            Console.ReadKey();
        }

        #region

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