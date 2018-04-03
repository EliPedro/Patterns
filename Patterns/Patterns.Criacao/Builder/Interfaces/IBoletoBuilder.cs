using System;

namespace Patterns.Criacao.Builder.Interfaces
{
    public interface IBoletoBuilder
    {
        void BuildCedente(String cedente);

        void BuildValor(Decimal valor);

        void BuildVencimento(DateTime vencimento);

        void BuildNossoNumero(Int32 nossoNumero);

        void BuildSacado(String sacado);

        IBoleto ObterBoleto();
    }
}