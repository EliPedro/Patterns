using Patterns.Estrutura.Decorator.Interfaces;

namespace Patterns.Estrutura.Decorator
{
    public class EmissorDecoratorComCompressao : EmissorDecorator
    {
        public EmissorDecoratorComCompressao(IEmissor emissor) : base(emissor)
        {
        }

        public override void Envia(string mensagem)
        {
            ObterEmissor().Envia(ComprimirMensagem(mensagem));
        }
    }
}