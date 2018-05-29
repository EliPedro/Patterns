using Patterns.Estrutura.Flyweight.Interfaces;
using System;

namespace Patterns.Estrutura.Flyweight
{
    public class TemaHifen : ITemaFlyweight
    {
        public void Imprime(string titulo, string texto)
        {
            Console.WriteLine("---------- " + titulo + " ----------");
            Console.WriteLine(texto);
            var rodape = new char[22 + titulo.Length];
            Array.Fill(rodape, '-');
            Console.WriteLine(rodape);
        }
    }
}