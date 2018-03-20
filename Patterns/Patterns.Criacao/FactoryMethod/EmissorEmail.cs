using Patterns.Criacao.FactoryMethod.Interfaces;
using System;
using System.Threading.Tasks;

namespace Patterns.Criacao.FactoryMethod
{
    public class EmissorEmail : IEmissor
    {
        public void EnviarMensagem()
        {
            Console.WriteLine($"Enviando Email de forma síncrona!!");
        }
        public async Task EnviarMensagemAsync()
        {
            await Task.Run(() => {
                Console.WriteLine("Enviando Email de forma assíncrona!!");
            });
        }
    }
}
