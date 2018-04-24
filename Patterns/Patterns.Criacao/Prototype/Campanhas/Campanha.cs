using Patterns.Criacao.Prototype.Interfaces;
using System;
using System.Text;

namespace Patterns.Criacao.Prototype.Campanhas
{
    public class Campanha : IPrototype<Campanha>
    {
        public string Nome { get; private set; }
        public DateTime Vencimento { get; private set; }
        public Guid PalavraChave { get; private set; }

        public Campanha(string nome, DateTime vencimento, Guid palavraChave)
        {
            Nome = nome;
            Vencimento = vencimento;
            PalavraChave = palavraChave;
        }

        public Campanha Clone()
        {
            var nome = "Cópia da Campanha : " + Nome;

            return new Campanha(nome, Vencimento, Guid.NewGuid());
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("\n");
            builder.Append($"Campanha : {Nome}");
            builder.Append($"\n");
            builder.Append($"Vencimento : {Vencimento}");
            builder.Append($"\n");
            builder.Append($"Palavra Chave : {PalavraChave.ToString()}");
            builder.Append($"\n");
            return builder.ToString();
        }
    }
}