using Patterns.Criacao.Builder.Boletos;
using Patterns.Criacao.Builder.Interfaces;
using System;

namespace Patterns.Criacao.Build.Boletos
{
    public class BBBoletoBuilder : AbstractBoletoBuild, IBoletoBuilder
    {
        public void BuildCedente(string cedente)
        {
            this.buildCedente = cedente;
        }

        public void BuildNossoNumero(int nossoNumero)
        {
            this.buildNossoNumero = nossoNumero;
        }

        public void BuildSacado(string sacado)
        {
            this.buildSacado = sacado;
        }

        public void BuildValor(decimal valor)
        {
            this.buildValor = valor;
        }

        public void BuildVencimento(DateTime vencimento)
        {
            this.buildVencimento = vencimento;
        }

        public IBoleto ObterBoleto()
        {
            return new BBBoleto(buildSacado, buildCedente, buildValor, buildVencimento, buildNossoNumero);
        }
    }
}