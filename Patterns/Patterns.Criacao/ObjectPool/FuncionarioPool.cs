using Patterns.Criacao.ObjectPool.Interfaces;
using System.Collections.Generic;

namespace Patterns.Criacao.ObjectPool
{
    public class FuncionarioPool : IPool<Funcionario>
    {
        private List<Funcionario> funcionarios;

        public FuncionarioPool()
        {
            funcionarios = new List<Funcionario>();
        }

        public Funcionario Acquire()
        {
            if (funcionarios.Count > 0)
            {
                var funcionario = funcionarios[0]; funcionarios.RemoveAt(0);

                return funcionario;
            }

            return null;
        }

        public void Release(Funcionario entidade)
        {
            funcionarios.Add(entidade);
        }

        public void Release(IList<Funcionario> entidades)
        {
            funcionarios.InsertRange(0, entidades);
        }
    }
}