using Patterns.Aplicacao.Utilitarios.Enum;

namespace Patterns.Criacao.AbstractFactory.Interfaces
{
    public interface IEmissorCreator
    {
        IEmissor Create(TipoEmissor tipoEmissor);
    }
}