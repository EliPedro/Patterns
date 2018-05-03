namespace Patterns.Estrutura.Adapter
{
    public class Empregado
    {
        public string Nome { get; private set; }

        public Empregado(string nome)
        {
            Nome = nome;
        }
    }
}