using Patterns.Aplicacao.Utilitarios.Enum;
using Patterns.Criacao.FactoryMethod.Interfaces;
using System;
using System.Threading.Tasks;

namespace Patterns.Criacao.FactoryMethod
{
    public class FactoryEmissor : IFactoryEmissor
    {
        public IEmissor Create(TipoEmissor tipoEmissor)
        {
            switch (tipoEmissor)
            {
                case TipoEmissor.Email:
                    return new EmissorEmail();
                case TipoEmissor.SMS:
                    return new EmissorSMS();
                default:
                    {
                        throw new NotImplementedException("Opção inválida !!");
                    }
            }
        }

        public async Task<IEmissor> CreateAsync(TipoEmissor tipoEmissor)
        {
            switch (tipoEmissor)
            {
                case TipoEmissor.Email:
                    return await Task.FromResult(new EmissorEmail());
                case TipoEmissor.SMS:
                    return await Task.FromResult(new EmissorSMS());
                default:
                    {
                        throw new NotImplementedException("Opção inválida !!");
                    }
            }
        }
    }
}
