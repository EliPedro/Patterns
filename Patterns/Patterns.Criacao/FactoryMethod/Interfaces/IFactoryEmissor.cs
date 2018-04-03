using Patterns.Aplicacao.Utilitarios.Enum;
using System.Threading.Tasks;

namespace Patterns.Criacao.FactoryMethod.Interfaces
{
    public interface IFactoryEmissor
    {
        IEmissor Create(TipoEmissor tipoEmissor);

        Task<IEmissor> CreateAsync(TipoEmissor tipoEmissor);
    }
}