using System.Collections.Generic;

namespace Patterns.Criacao.ObjectPool.Interfaces
{
    public interface IPool<T> where T : class
    {
        T Acquire();

        void Release(T entidade);

        void Release(IList<T> entidades);
    }
}