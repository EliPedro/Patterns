namespace Patterns.Criacao.Prototype.Interfaces
{
    public interface IPrototype<T> where T : class
    {
        T Clone();
    }
}