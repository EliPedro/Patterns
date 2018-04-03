using Patterns.Criacao.Builder.Interfaces;
using System;
using System.Text;

namespace Patterns.Criacao.Builder.Boletos
{
    public sealed class BBBoleto : IBoleto
    {
        private readonly String _sacado;
        private readonly String _cedente;
        private readonly Decimal _valor;
        private readonly DateTime _vencimento;
        private readonly Int32 _nossoNumero;

        public BBBoleto(String sacado, String cedente, Decimal valor, DateTime vencimento, Int32 nossoNumero)
        {
            _sacado = sacado;
            _cedente = cedente;
            _valor = valor;
            _vencimento = vencimento;
            _nossoNumero = nossoNumero;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"\n......{ GetType().Name }......\n");
            stringBuilder.Append("\n");
            stringBuilder.Append(" Sacado : " + _sacado);
            stringBuilder.Append("\n");
            stringBuilder.Append(" Cedente : " + _cedente);
            stringBuilder.Append("\n");
            stringBuilder.Append(string.Format(" Valor : R$ {0:N2}", _valor));
            stringBuilder.Append("\n");
            stringBuilder.Append(" Vencimento : " + _sacado);
            stringBuilder.Append("\n");
            stringBuilder.Append(" Vencimento : " + _vencimento);
            stringBuilder.Append("\n");
            stringBuilder.Append(" Nosso Número : " + _nossoNumero);
            stringBuilder.Append("\n");
            return stringBuilder.ToString();
        }
    }
}