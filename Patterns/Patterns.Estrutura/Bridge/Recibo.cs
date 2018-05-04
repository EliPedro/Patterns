using Patterns.Estrutura.Bridge.Interfaces;
using System;
using System.Text;

namespace Patterns.Estrutura.Bridge
{
    public class Recibo : IDocumento
    {
        public String Emissor { get; private set; }
        public String Favorecido { get; private set; }
        public Decimal Valor { get; private set; }
        private readonly IGeradorDeArquivo geradorDeArquivo;

        public Recibo(String emissor, String favorecido, Decimal valor, IGeradorDeArquivo _geradorDeArquivo)
        {
            Emissor = emissor;
            Favorecido = favorecido;
            Valor = valor;
            geradorDeArquivo = _geradorDeArquivo;
        }

        public void GerarArquivo()
        {
            var conteudo = new StringBuilder();
            conteudo.Append("Recibo : ");
            conteudo.Append("\n");
            conteudo.Append(" Empresa : " + this.Emissor);
            conteudo.Append("\n");
            conteudo.Append(" Cliente : " + this.Favorecido);
            conteudo.Append("\n");
            conteudo.Append(" Valor : " + this.Valor);
            conteudo.Append("\n");
            geradorDeArquivo.Gerar(conteudo.ToString());
        }
    }
}