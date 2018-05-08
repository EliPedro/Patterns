using Patterns.Estrutura.Composite.Interfaces;
using System.Collections.Generic;

namespace Patterns.Estrutura.Composite
{
    public class Caminho : ITrecho
    {
        private IList<ITrecho> trechos;

        public Caminho()
        {
            trechos = new List<ITrecho>();
        }

        public void Adicionar(ITrecho trecho)
        {
            trechos.Add(trecho);
        }

        public void Remover(ITrecho trecho)
        {
            trechos.Remove(trecho);
        }

        public void Imprimir()
        {
            foreach (var trecho in trechos)
            {
                trecho.Imprimir();
            }
        }
    }
}