using System;

namespace Patterns.Estrutura.Bridge.Interfaces
{
    public interface IGeradorDeArquivo
    {
        void Gerar(String conteudo);

        String ObterCaminhoArquivo();
    }
}