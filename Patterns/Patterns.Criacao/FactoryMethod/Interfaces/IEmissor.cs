using System.Threading.Tasks;

namespace Patterns.Criacao.FactoryMethod.Interfaces
{
    public interface IEmissor
    {
        void EnviarMensagem();

        Task EnviarMensagemAsync();
    }
}