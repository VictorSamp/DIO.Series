using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        internal List<T> Lista();

        internal T RetornaPorId(int id);

        internal void Insere(T entidade);

        internal void Exclui(int id);

        internal void Atualiza(int id, T entidade);

        internal int ProximoId();
    }
}