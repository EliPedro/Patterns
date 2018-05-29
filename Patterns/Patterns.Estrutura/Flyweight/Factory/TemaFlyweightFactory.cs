using Patterns.Estrutura.Flyweight.Enum;
using Patterns.Estrutura.Flyweight.Interfaces;
using System;
using System.Collections.Generic;

namespace Patterns.Estrutura.Flyweight.Factory
{
    public sealed class TemaFlyweightFactory
    {
        private static IDictionary<TemaFlyweightEnum, ITemaFlyweight> temas = new Dictionary<TemaFlyweightEnum, ITemaFlyweight>();

        public static ITemaFlyweight ObterTema<T>(TemaFlyweightEnum @key) where T : ITemaFlyweight
        {
            if (!temas.ContainsKey(@key))
            {
                temas.Add(@key, Activator.CreateInstance<T>());
            }

            return temas[@key];
        }
    }
}