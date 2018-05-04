using Patterns.Estrutura.Bridge.Interfaces;
using System;
using System.IO;

namespace Patterns.Estrutura.Bridge
{
    public class GeradorDeArquivoTXT : IGeradorDeArquivo
    {
        public void Gerar(string conteudo)
        {
            try
            {
                using (var stream = new StreamWriter(ObterCaminhoArquivo(), true))
                {
                    stream.WriteLine(conteudo);
                }
                Console.WriteLine("Arquivo TXT gerado com sucesso!!!");
            }
            catch (FileNotFoundException)
            {
            }
            catch (Exception)
            {
            }
        }

        public string ObterCaminhoArquivo()
        {
            var path = Path.Combine(@"C:\", "arquivo.txt");

            return path;
        }
    }
}