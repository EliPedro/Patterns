namespace Patterns.Estrutura.Adapter.Interfaces
{
    public interface IControleDePonto
    {
        void RegistrarEntrada(Empregado f);

        void RegistrarSainda(Empregado f);
    }
}