using System;
using System.Collections.Generic;

namespace Patterns.Estrutura.Flyweight
{
    public class Apresentacao
    {
        private IList<Slide> slides = null;

        public Apresentacao()
        {
            slides = new List<Slide>();
        }

        public void AdicionaSlide(Slide slide)
        {
            slides.Add(slide);
        }

        public void Imprime()
        {
            foreach (var slide in slides)
            {
                slide.Imprime();
                Console.WriteLine();
            }
        }
    }
}