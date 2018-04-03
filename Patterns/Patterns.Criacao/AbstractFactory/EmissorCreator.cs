using Patterns.Aplicacao.Utilitarios.Enum;
using Patterns.Criacao.AbstractFactory.Interfaces;
using System;

namespace Patterns.Criacao.AbstractFactory
{
    public class EmissorCreator : IEmissorCreator
    {
        public IEmissor Create(TipoEmissor tipoEmissor)
        {
            switch (tipoEmissor)
            {
                case TipoEmissor.MasterCard:
                    return new EmissorMasterCard();

                default:
                    {
                        throw new NotImplementedException("Opção inválida !!");
                    }
            }
        }
    }
}