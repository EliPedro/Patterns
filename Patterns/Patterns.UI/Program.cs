using Patterns.Aplicacao.Utilitarios.Enum;
using Patterns.Criacao.FactoryMethod;
using System;
using System.Threading.Tasks;

namespace Patterns.UI
{
    class Program
    {
        static  void Main(string[] args)
        {
            Task.Run(async () =>
            {
               await TestarFactoryMethodAsync();
            });

            Console.ReadKey();
        }
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
