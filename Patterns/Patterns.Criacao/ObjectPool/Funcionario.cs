using System;

namespace Patterns.Criacao.ObjectPool
{
    public class Funcionario
    {
        public string Codigo { get; private set; }
        public string Nome { get; private set; }

        public Funcionario(string nome)
        {
            Codigo = Guid.NewGuid().ToString();
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Código: {Codigo} Nome: {Nome}";
        }
    }
}