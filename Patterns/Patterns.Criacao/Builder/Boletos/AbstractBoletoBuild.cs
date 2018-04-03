using System;

namespace Patterns.Criacao.Builder.Boletos
{
    public abstract class AbstractBoletoBuild
    {
        protected String buildCedente;
        protected Decimal buildValor;
        protected DateTime buildVencimento;
        protected Int32 buildNossoNumero;
        protected String buildSacado;
    }
}