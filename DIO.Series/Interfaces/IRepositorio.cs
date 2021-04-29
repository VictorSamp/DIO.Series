using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        public List<T> Lista();

        public T RetornarPorId(int id);

        public void Inserir(T entidade);

        public void Excluir(int id);

        public void Atualizar(int id, T entidade);

        public int ProximoId();
    }
}