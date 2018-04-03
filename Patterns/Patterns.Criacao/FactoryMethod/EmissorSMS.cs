using Patterns.Criacao.FactoryMethod.Interfaces;
using System;
using System.Threading.Tasks;

namespace Patterns.Criacao.FactoryMethod
{
    public class EmissorSMS : IEmissor
    {
        public void EnviarMensagem()
        {
            Console.WriteLine("Enviando SMS de forma síncrona!!");
        }

        public async Task EnviarMensagemAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Enviando SMS de forma assíncrona!!");
            });
        }
    }
}