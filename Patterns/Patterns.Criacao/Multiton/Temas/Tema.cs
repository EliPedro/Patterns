using Patterns.Criacao.Multiton.Utilitarios;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Patterns.Criacao.Multiton.Temas
{
    public class Tema
    {
        public String Nome { get; private set; }
        public Color CorDoFundo { get; private set; }
        public Color CorDaFonte { get; private set; }
        private static IDictionary<TemasEnum, Tema> temas;

        private Tema()
        {
        }

        public static Tema ObterTema(TemasEnum key)
        {
            if (temas == null)
            {
                BuilderTemas();
            }

            return temas[key];
        }

        private static IDictionary<TemasEnum, Tema> BuilderTemas()
        {
            temas = new Dictionary<TemasEnum, Tema>();

            temas.Add(TemasEnum.Sky, new Tema
            {
                Nome = "Sky",
                CorDaFonte = Color.White,
                CorDoFundo = Color.Red,
            });

            temas.Add(TemasEnum.Fire, new Tema
            {
                Nome = "Fire",
                CorDaFonte = Color.Black,
                CorDoFundo = Color.White,
            });

            return temas;
        }
    }
}