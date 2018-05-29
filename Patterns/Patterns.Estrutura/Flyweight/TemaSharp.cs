using Patterns.Estrutura.Flyweight.Interfaces;
using System;

namespace Patterns.Estrutura.Flyweight
{
    public class TemaSharp : ITemaFlyweight
    {
        public void Imprime(string titulo, string texto)
        {
            Console.WriteLine("########## " + titulo.ToUpper() + " ########## ");
            Console.WriteLine(texto);
            char[] rodapeE = new char[(int)Math.Floor((6 + titulo.Length) / 2.0)];
            char[] rodapeD = new char[(int)Math.Ceiling((6 + titulo.Length) / 2.0)];
            Array.Fill(rodapeE, '#');
            Array.Fill(rodapeD, '#');
            Console.WriteLine(new String(rodapeE) + " www.java.com " + new String(rodapeD));
        }
    }
}