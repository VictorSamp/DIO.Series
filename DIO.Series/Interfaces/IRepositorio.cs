using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        public List<T> Lista();

        public T RetornaPorId(int id);

        public void Insere(T entidade);

        public void Exclui(int id);

        public void Atualiza(int id, T entidade);

        public int ProximoId();
    }
}