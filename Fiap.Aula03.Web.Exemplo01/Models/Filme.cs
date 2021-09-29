﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Exemplo01.Models
{
    [Table("Tbl_Filme")]
    public class Filme
    {
        [Column("Id"), HiddenInput]
        public int FilmeId { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }
        
        public int? Ano { get; set; }

        [MaxLength(200)]
        public string Sinopse { get; set; }

        [Column("Data_Lancamento"), Required, Display(Name = "Data Lançamento"), DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Column("Maior_Idade"), Display(Name = "Maior Idade")]
        public bool MaiorIdade { get; set; }

        [Column("Genero")]
        public Genero Genero { get; set; }
    }

    public enum Genero
    {
        Acao, Aventura, Comedia, Terror, Romance
    }
}
