using Patterns.Estrutura.Decorator.Interfaces;
using System;

namespace Patterns.Estrutura.Decorator
{
    public class EmissorBasico : IEmissor
    {
        public void Envia(string mensagem)
        {
            Console.WriteLine("Enviando uma mensagem : ");
            Console.WriteLine(mensagem);
        }
    }
}