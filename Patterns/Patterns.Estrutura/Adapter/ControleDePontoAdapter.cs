using Patterns.Estrutura.Adapter.Interfaces;

namespace Patterns.Estrutura.Adapter
{
    public class ControleDePontoAdapter : ControleDePonto
    {
        private IControleDePontoNovo _controleDePontoNovo;

        public ControleDePontoAdapter(IControleDePontoNovo controleDePontoNovo)
        {
            _controleDePontoNovo = controleDePontoNovo;
        }

        public override void RegistrarEntrada(Empregado f)
        {
            _controleDePontoNovo.Registrar(f, true);
        }

        public override void RegistrarSainda(Empregado f)
        {
            _controleDePontoNovo.Registrar(f, false);
        }
    }
}