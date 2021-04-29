using DIO.Series.Entities;
using DIO.Series.Enums;
using System.Text;

namespace DIO.Entities
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Gênero: {Genero}");
            stringBuilder.AppendLine($"Titulo: {Titulo}");
            stringBuilder.AppendLine($"Descrição: {Descricao}");
            stringBuilder.AppendLine($"Ano de Lançamento: {Ano}");
            return stringBuilder.ToString();
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaId()
        {
            return Id;
        }
    }
}