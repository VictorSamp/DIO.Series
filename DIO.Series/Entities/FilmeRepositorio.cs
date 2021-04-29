using DIO.Series.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DIO.Series.Entities
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaSerie = new List<Filme>();

        public void Atualizar(int id, Filme objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Inserir(Filme objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Filme> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count();
        }

        public Filme RetornarPorId(int id)
        {
            return listaSerie[id];
        }
    }
}