using Patterns.Criacao.AbstractFactory.Interfaces;
using System;

namespace Patterns.Criacao.AbstractFactory
{
    public class EmissorMasterCard : IEmissor
    {
        public void Mensagem()
        {
            Console.WriteLine("Enviando mensagem para a MasterCard.");
        }
    }
}