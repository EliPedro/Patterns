using Patterns.Estrutura.Flyweight.Interfaces;
using System;

namespace Patterns.Estrutura.Flyweight
{
    public class Slide
    {
        private readonly ITemaFlyweight tema;
        private readonly String titulo;
        private readonly String texto;

        public Slide(ITemaFlyweight _tema, String _titulo, String _texto)
        {
            tema = _tema;
            titulo = _titulo;
            texto = _texto;
        }

        public void Imprime()
        {
            tema.Imprime(titulo, texto);
        }
    }
}