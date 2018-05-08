using Patterns.Estrutura.Composite.Interfaces;
using System;

namespace Patterns.Estrutura.Composite
{
    public class TrechoAndando : ITrecho
    {
        public string Direcao { get; private set; }
        public int Distancia { get; private set; }

        public TrechoAndando(string direcao, int distancia)
        {
            Direcao = direcao;
            Distancia = distancia;
        }

        public void Imprimir()
        {
            Console.WriteLine("Vá Andando :");
            Console.WriteLine(Direcao);
            Console.WriteLine("A distância percorrida será de: " + Distancia + " metros");
        }
    }
}