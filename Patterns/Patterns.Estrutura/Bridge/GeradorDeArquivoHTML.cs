using Patterns.Estrutura.Bridge.Interfaces;
using System;

namespace Patterns.Estrutura.Bridge
{
    public class GeradorDeArquivoHTML : IGeradorDeArquivo
    {
        public void Gerar(string conteudo)
        {
            throw new NotImplementedException();
        }

        public string ObterCaminhoArquivo()
        {
            throw new NotImplementedException();
        }
    }
}