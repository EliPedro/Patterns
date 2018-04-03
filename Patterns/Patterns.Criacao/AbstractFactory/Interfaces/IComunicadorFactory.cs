namespace Patterns.Criacao.AbstractFactory.Interfaces
{
    public interface IComunicadorFactory
    {
        IEmissor CreateEmissor();

        IReceptor CreateReceptor();
    }
}