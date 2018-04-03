using Patterns.Criacao.Builder.Interfaces;
using System;

namespace Patterns.Criacao.Builder.Boletos
{
    public class GeradorBoleto : IGeradorBoleto
    {
        private readonly IBoletoBuilder _boletoBuild;

        public GeradorBoleto(IBoletoBuilder boletoBuild)
        {
            _boletoBuild = boletoBuild;
        }

        public IBoleto GerarBoleto()
        {
            _boletoBuild.BuildSacado("Teste");
            _boletoBuild.BuildCedente("Treinamentos ");
            _boletoBuild.BuildValor(100M);
            _boletoBuild.BuildVencimento(DateTime.Now.AddDays(20));
            _boletoBuild.BuildNossoNumero(1234);

            return _boletoBuild.ObterBoleto();
        }
    }
}