using Patterns.Estrutura.Decorator.Interfaces;
using System;

namespace Patterns.Estrutura.Decorator
{
    public class EmissorDecoratorComCriptografia : EmissorDecorator
    {
        public EmissorDecoratorComCriptografia(IEmissor emissor) : base(emissor)
        {
        }

        public override void Envia(string mensagem)
        {
            ObterEmissor().Envia(CriptografarMensagem(mensagem));
        }
    }
}