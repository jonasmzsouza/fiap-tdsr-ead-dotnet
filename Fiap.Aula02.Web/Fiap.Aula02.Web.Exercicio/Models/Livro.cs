using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exercicio.Models
{
    public class Livro
    {
        [Display(Name = "Código")]
        public int Codigo { get; set; }
        public string Titulo { get; set; }

        [DataType(DataType.Date), Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; }
        public bool Novo { get; set; }
        public string Editora { get; set; }

    }

    public enum Categoria
    {
        Biografias, Crítica, Ficção, Folclore, Humor, Poesia, Sexualidade, Religião, Esoterismo, Esportes, História, Outros
    }

}
