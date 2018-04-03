using Patterns.Aplicacao.Utilitarios.Enum;
using Patterns.Criacao.AbstractFactory.Interfaces;
using System;

namespace Patterns.Criacao.AbstractFactory
{
    public class ComunicadorFactoryMasterCard : IComunicadorFactory
    {
        private readonly IEmissorCreator _emissorCreator;

        public ComunicadorFactoryMasterCard(IEmissorCreator emissorCreator)
        {
            _emissorCreator = emissorCreator;
        }

        public IEmissor CreateEmissor()
        {
            return _emissorCreator.Create(TipoEmissor.MasterCard);
        }

        public IReceptor CreateReceptor()
        {
            throw new NotImplementedException();
        }
    }
}