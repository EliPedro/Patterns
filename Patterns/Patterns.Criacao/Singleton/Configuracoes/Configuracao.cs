using Patterns.Criacao.Singleton.Utilitarios;
using System.Collections.Generic;

namespace Patterns.Criacao.Singleton.Configuracoes
{
    public class Configuracao
    {
        private static Configuracao instance;
        private IDictionary<PropriedadesEnum, string> configuracao;

        private Configuracao()
        {
            configuracao = new Dictionary<PropriedadesEnum, string>();

            configuracao.Add(PropriedadesEnum.TimeZone, "America/Sao_paulo");
            configuracao.Add(PropriedadesEnum.CurrencyCode, "BR");
        }

        public static Configuracao GetInstance()
        {
            if (instance == null)
            {
                instance = new Configuracao();
                return instance;
            }

            return instance;
        }

        public string ObterPropriedade(PropriedadesEnum key)
        {
            return configuracao[key];
        }
    }
}